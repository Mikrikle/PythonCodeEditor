using System.IO;
using System.Diagnostics;

namespace PythonCodeEditor
{
    public partial class mainWindow : Form
    {
        public struct ShortcutData
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

        public Dictionary<string, ShortcutData> shortcuts = new()
        {
            { "p", new ShortcutData("print(f\"{}\")", 3) }
        };


        public static class ErrorMessage
        {
            public static void Show(string text)
            {
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class BlueRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = Color.MediumBlue;
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
        }

        public mainWindow()
        {
            InitializeComponent();
        }

        private void Button_run_Click(object sender, EventArgs e)
        {
            string path = @"temp.py";
            try
            {
                File.WriteAllText(path, codeEditor.Text);

                try
                {
                    Process.Start("python.exe", "-i " + Directory.GetCurrentDirectory() + @"\" + path);
                }
                catch (Exception error2)
                {
                    ErrorMessage.Show($"python.exe not found\n\n{error2.Message}");
                }

            }
            catch (Exception error)
            {
                ErrorMessage.Show($"Unable to create a file\n\n{error.Message}");
            }
        }

        private void Button_python_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("python.exe");
            }
            catch (Exception error)
            {
                ErrorMessage.Show($"python.exe not found\n\n{error.Message}");
            }
        }

        private void Button_console_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cmd.exe");
            }
            catch (Exception error)
            {
                ErrorMessage.Show($"cmd.exe not found\n\n{error.Message}");
            }
        }

        private void CodeEditor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if(codeEditor.Text.Length == 0 || codeEditor.SelectionStart == 0)
                {
                    codeEditor.Paste("    ");
                }
                else
                {
                    
                    char prevChar = codeEditor.Text[codeEditor.SelectionStart - 1];
                    if (prevChar != '\n')
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
                    }
                    else
                    {
                        codeEditor.Paste("    ");
                    }
                }
                e.IsInputKey = true;
            }
        }

        private void CodeEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
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
    }
}