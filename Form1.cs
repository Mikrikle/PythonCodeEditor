using System.IO;
using System.Diagnostics;

namespace PythonCodeEditor
{
    public partial class mainWindow : Form
    {
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

        private Dictionary<string, ShortcutData> shortcuts = new()
        {
            { "p", new ShortcutData("print(f\"{}\")", 3) }
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
            string path = @"temp.py";
            try
            {
                File.WriteAllText(path, codeEditor.Text);

                TryRun(
                    "python.exe",
                    "-i " + Directory.GetCurrentDirectory() + @"\" + path,
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
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.FontColor = label_example.ForeColor;
            Properties.Settings.Default.BackgroundColor = label_example.BackColor;
            Properties.Settings.Default.Font = label_example.Font;
            Properties.Settings.Default.Save();
        }

        public mainWindow()
        {
            InitializeComponent();
        }

        private void Button_run_Click(object sender, EventArgs e)
        {
            RunPython();
        }

        private void Button_python_Click(object sender, EventArgs e)
        {
            TryRun("python.exe", errorMessage: "python.exe not found");
        }

        private void Button_console_Click(object sender, EventArgs e)
        {
            TryRun("cmd.exe", errorMessage: "cmd.exe not found");
        }

        private void CodeEditor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
                return;


            if(codeEditor.Text.Length > 0 && codeEditor.SelectionStart > 0
                && codeEditor.Text[codeEditor.SelectionStart - 1] != '\n')
            {
                string[] textrows = codeEditor.Text[0..codeEditor.SelectionStart].Split('\n');
                string shortcut = textrows.Last();
                if (shortcuts.TryGetValue(shortcut, out ShortcutData insertion))
                {
                    int pos = codeEditor.SelectionStart;
                    codeEditor.Text = codeEditor.Text.Remove(pos - shortcut.Length, shortcut.Length);
                    codeEditor.SelectionStart = pos - shortcut.Length;
                    codeEditor.Paste(insertion.Text);
                    codeEditor.SelectionStart -= insertion.StepBack;
                }
                else
                {
                    codeEditor.Paste("    ");
                }
            }
            else
            {
                codeEditor.Paste("    ");
            }
            e.IsInputKey = true;
        }

        private void CodeEditor_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void CodeEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '(':
                    codeEditor.Paste(")");
                    codeEditor.SelectionStart -= 1;
                    break;
                case '"':
                    codeEditor.Paste("\"");
                    codeEditor.SelectionStart -= 1;
                    break;
                case '\'':
                    codeEditor.Paste("\'");
                    codeEditor.SelectionStart -= 1;
                    break;
                case '<':
                    codeEditor.Paste(">");
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

        private void Button_fontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog_font.ShowDialog() == DialogResult.OK)
            {
                label_example.ForeColor = colorDialog_font.Color;
                codeEditor.ForeColor = colorDialog_font.Color;
                SaveSettings();
            }
        }

        private void button_bgColor_Click(object sender, EventArgs e)
        {
            if (colorDialog_bg.ShowDialog() == DialogResult.OK)
            {
                label_example.BackColor = colorDialog_bg.Color;
                codeEditor.BackColor = colorDialog_bg.Color;
                SaveSettings();
            }
        }

        private void button_font_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label_example.Font = fontDialog.Font;
                codeEditor.Font = fontDialog.Font;
                SaveSettings();
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            label_example.Font = new Font("Consolas", 11);
            label_example.BackColor = Color.FromArgb(30, 30, 30);
            label_example.ForeColor = Color.FromArgb(255, 255, 255);
            SaveSettings();
            ApplySettings();
        }
    }
}