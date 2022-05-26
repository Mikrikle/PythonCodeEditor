using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PythonCodeEditor
{

    public partial class mainWindow : Form
    {
        private string FileName { get; set; }

        private static readonly string[] pyKeyWords = {
            "False", "class", "from",
            "or", "None", "continue",
            "global", "pass", "True",
            "def", "if", "raise",
            "and", "del", "import",
            "return", "as", "elif",
            "in", "try", "assert",
            "else", "is", "while",
            "async", "except", "lambda",
            "with", "await", "finally",
            "nonlocal", "yield", "break",
            "for", "not"
        };

        private struct ShortcutData
        {
            public string Text { get; set; } = "";
            public int StepBack { get; set; } = 0;
            public ShortcutData() { }
            public ShortcutData(string text, int stepBack)
            {
                Text = text;
                StepBack = stepBack;
            }
            public override string ToString() => $"Text: {Text} StepBack: {StepBack}";
        }

        private readonly Dictionary<string, ShortcutData> shortcuts_dict = new()
        {
            { "p", new ShortcutData("print(f\"{}\")", 3) },
            { "for", new ShortcutData("for i in range():", 2) },
            { "forfor", new ShortcutData("for i in range():\n    for j in range():", 2) },
        };

        private static class ErrorMessage
        {
            public static void Show(string text)
            {
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void TryRun(string processName, string args="", string errorMessage="")
        {
            try
            {
                Process.Start(processName, args);
            }
            catch (Exception error)
            {
                ErrorMessage.Show($"{errorMessage}\n\n{error.Message}");
            }
        }

        private void RunPython()
        {
            try
            {
                File.WriteAllText(Properties.Settings.Default.pyTempPath, codeEditor.Text);

                TryRun(
                    "python.exe",
                    "-i " + FileName,
                    "python.exe not found"
                    );
            }
            catch (Exception error)
            {
                ErrorMessage.Show($"Unable to create a file\n\n{error.Message}");
            }
        }

        private void ApplySettings()
        {
            codeEditor.ForeColor = Properties.Settings.Default.FontColor;
            codeEditor.BackColor = Properties.Settings.Default.BackgroundColor;
            codeEditor.Font = Properties.Settings.Default.Font;

            label_example.ForeColor = Properties.Settings.Default.FontColor;
            label_example.BackColor = Properties.Settings.Default.BackgroundColor;
            label_example.Font = Properties.Settings.Default.Font;

            label_example.SelectionStart = label_example.Find("for");
            label_example.SelectionLength = 3;
            label_example.SelectionColor = Properties.Settings.Default.pyColor;
            label_example.SelectionStart += 6;
            label_example.SelectionLength = 2;
            label_example.SelectionColor = Properties.Settings.Default.pyColor;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }

        private void OffSound(KeyEventArgs e)
        {
            if (
                codeEditor.GetLineFromCharIndex(codeEditor.SelectionStart) == 0 &&
                e.KeyData == Keys.Up ||
                codeEditor.GetLineFromCharIndex(codeEditor.SelectionStart) == codeEditor.GetLineFromCharIndex(codeEditor.TextLength) &&
                e.KeyData == Keys.Down ||
                codeEditor.SelectionStart == codeEditor.TextLength &&
                e.KeyData == Keys.Right ||
                codeEditor.SelectionStart == 0 &&
                e.KeyData == Keys.Left
            ) { e.Handled = true; };
        }

        private System.Windows.Forms.Timer highlightTimer = new System.Windows.Forms.Timer();

        private void HighlightText(object sender, EventArgs e)
        {
            HighlightText();
        }

        private void HighlightText()
        {
            int pos = codeEditor.SelectionStart;

            codeEditor.SelectAll();
            codeEditor.SelectionColor = Properties.Settings.Default.FontColor;

            foreach (string word in pyKeyWords)
            {
                string pattern = @"(?<!\S)" + word + @"(?!\S)+";
                foreach (Match match in Regex.Matches(codeEditor.Text, pattern, RegexOptions.IgnoreCase))
                {
                    codeEditor.SelectionStart = match.Index;
                    codeEditor.SelectionLength = word.Length;
                    codeEditor.SelectionColor = Properties.Settings.Default.pyColor;
                }
            }
            codeEditor.DeselectAll();
            codeEditor.SelectionStart = pos;
            codeEditor.ScrollToCaret();
            highlightTimer.Stop();
        }

        private int calcTabIndex()
        {
            int nLine = codeEditor.GetLineFromCharIndex(codeEditor.SelectionStart);
            string line = nLine == 0 ? codeEditor.Text : codeEditor.Lines[nLine];
            int nSpaces = 0;
            foreach (char symbol in line)
            {
                if (symbol != ' ')
                    break;
                nSpaces++;
            }
            return nSpaces / 4;
        }

        public mainWindow()
        {
            highlightTimer.Interval = 1000;
            highlightTimer.Tick += new EventHandler(HighlightText);
            highlightTimer.Start();
            InitializeComponent();
            FileName = Directory.GetCurrentDirectory() + @"\" + Properties.Settings.Default.pyTempPath;
            toolStripStatusLabel1.Text = FileName;
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            RunPython();
        }

        private void button_python_Click(object sender, EventArgs e)
        {
            TryRun("python.exe", errorMessage: "python.exe not found");
        }

        private void button_console_Click(object sender, EventArgs e)
        {
            TryRun("cmd.exe", errorMessage: "cmd.exe not found");
        }

        private void codeEditor_KeyUp(object sender, KeyEventArgs e)
        {
            highlightTimer.Start();
            //HighlightText();
        }

        private void codeEditor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            highlightTimer.Stop();
            if (e.KeyCode != Keys.Tab)
                return;

            int nLine = codeEditor.GetLineFromCharIndex(codeEditor.SelectionStart);
            string shortcut = nLine == 0? codeEditor.Text.Trim(): codeEditor.Lines[nLine].Trim();

            if (shortcuts_dict.TryGetValue(shortcut, out ShortcutData insertion))
            {
                int pos = codeEditor.SelectionStart;
                codeEditor.Text = codeEditor.Text.Remove(pos - shortcut.Length, shortcut.Length);
                codeEditor.SelectionStart = pos - shortcut.Length;
                codeEditor.SelectedText = insertion.Text;
                codeEditor.SelectionStart -= insertion.StepBack;
            }
            else
            {
                codeEditor.SelectedText = "    ";
            }
            e.IsInputKey = true;
        }

        private void codeEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && e.Modifiers == Keys.Control)
            {
                RunPython();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if(codeEditor.Text.Length > 0 && codeEditor.SelectionStart > 0)
                {
                    int ifAddTab = codeEditor.Text[codeEditor.SelectionStart - 1] == ':'?1:0;
                    string sTabs = "";

                    for (int i = 0; i < calcTabIndex() + ifAddTab; i++)
                    {
                        sTabs += "    ";
                    }
                    codeEditor.SelectedText = "\n" + sTabs;
                    e.SuppressKeyPress = true;
                }
            }
            OffSound(e);
        }

        private void codeEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '(':
                    codeEditor.SelectedText = ")";
                    codeEditor.SelectionStart -= 1;
                    break;
                case '"':
                    codeEditor.SelectedText = "\"";
                    codeEditor.SelectionStart -= 1;
                    break;
                case '\'':
                    codeEditor.SelectedText = "\'";
                    codeEditor.SelectionStart -= 1;
                    break;
                case '[':
                    codeEditor.SelectedText = "]";
                    codeEditor.SelectionStart -= 1;
                    break;
                case '{':
                    codeEditor.SelectedText = "}";
                    codeEditor.SelectionStart -= 1;
                    break;
            }
        }

        private void button_editor_Click(object sender, EventArgs e)
        {
            tab_main.SelectedIndex = 0;
        }

        private void button_shortcuts_Click(object sender, EventArgs e)
        {
            tab_main.SelectedIndex = 1;
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            tab_main.SelectedIndex = 2;
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void button_fontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FontColor = colorDialog.Color;
                SaveSettings();
                ApplySettings();
            }

        }

        private void button_bgColor_Click(object sender, EventArgs e)
        {
            if (colorDialog_bg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackgroundColor = colorDialog_bg.Color;
                SaveSettings();
                ApplySettings();
            }
        }

        private void button_font_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Font = fontDialog.Font;
                SaveSettings();
                ApplySettings();
            }
            
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Font = new Font("Consolas", 11);
            Properties.Settings.Default.BackgroundColor = Color.FromArgb(30, 30, 30);
            Properties.Settings.Default.FontColor = Color.FromArgb(255, 255, 255);
            Properties.Settings.Default.pyColor = Color.FromArgb(86, 156, 214);
            ApplySettings();
            SaveSettings();
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(File.Exists(Properties.Settings.Default.pyTempPath))
            //{
                //File.Delete(path);
            //}
        }

        private void button_syntax_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.pyColor = colorDialog.Color;
                SaveSettings();
                ApplySettings();
                HighlightText();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Python files (*.py)|*.py|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = openFileDialog.FileName;
                    toolStripStatusLabel1.Text = FileName;
                    codeEditor.Text = File.ReadAllText(FileName);
                    HighlightText();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FileName, codeEditor.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Python files (*.py)|*.py|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, codeEditor.Text);
                }
            }
        }

        private void openTempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = Directory.GetCurrentDirectory() + @"\" + Properties.Settings.Default.pyTempPath;
            toolStripStatusLabel1.Text = FileName;
            codeEditor.Text = File.ReadAllText(FileName);
            HighlightText();
        }
    }
}