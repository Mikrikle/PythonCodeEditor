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
    }
}