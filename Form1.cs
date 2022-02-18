using System.IO;
using System.Diagnostics;

namespace PythonCodeEditor
{
    public partial class mainWindow : Form
    {
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
            File.WriteAllText(path, codeEditor.Text);
            File.AppendAllText(path, "\ninput('Press <Enter> to close')\n");
            Process.Start("python.exe", Directory.GetCurrentDirectory() + @"\" + path);
        }

        private void Button_python_Click(object sender, EventArgs e)
        {
            Process.Start("python.exe");
        }

        private void Button_console_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void CodeEditor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("    ");
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