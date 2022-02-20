namespace PythonCodeEditor
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_editor = new System.Windows.Forms.Button();
            this.button_shortcuts = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_console = new System.Windows.Forms.Button();
            this.button_python = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tab_editor = new System.Windows.Forms.TabPage();
            this.codeEditor = new System.Windows.Forms.RichTextBox();
            this.tab_shortcuts = new System.Windows.Forms.TabPage();
            this.label_shortcuts = new System.Windows.Forms.Label();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_example = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_reset = new System.Windows.Forms.Button();
            this.table_settings = new System.Windows.Forms.TableLayoutPanel();
            this.label_fontColor = new System.Windows.Forms.Label();
            this.button_fontColor = new System.Windows.Forms.Button();
            this.button_bgColor = new System.Windows.Forms.Button();
            this.button_font = new System.Windows.Forms.Button();
            this.label_bgColor = new System.Windows.Forms.Label();
            this.label_font = new System.Windows.Forms.Label();
            this.label_settings = new System.Windows.Forms.Label();
            this.imageList_tabs = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog_font = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog_bg = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tab_editor.SuspendLayout();
            this.tab_shortcuts.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.table_settings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.button_editor);
            this.panel1.Controls.Add(this.button_shortcuts);
            this.panel1.Controls.Add(this.button_settings);
            this.panel1.Controls.Add(this.button_console);
            this.panel1.Controls.Add(this.button_python);
            this.panel1.Controls.Add(this.button_run);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 495);
            this.panel1.TabIndex = 2;
            // 
            // button_editor
            // 
            this.button_editor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_editor.FlatAppearance.BorderSize = 0;
            this.button_editor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editor.Image = global::PythonCodeEditor.Properties.Resources.Edit;
            this.button_editor.Location = new System.Drawing.Point(0, 303);
            this.button_editor.Margin = new System.Windows.Forms.Padding(0);
            this.button_editor.Name = "button_editor";
            this.button_editor.Size = new System.Drawing.Size(64, 64);
            this.button_editor.TabIndex = 5;
            this.button_editor.UseVisualStyleBackColor = true;
            this.button_editor.Click += new System.EventHandler(this.button_editor_Click);
            // 
            // button_shortcuts
            // 
            this.button_shortcuts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_shortcuts.FlatAppearance.BorderSize = 0;
            this.button_shortcuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shortcuts.Image = global::PythonCodeEditor.Properties.Resources.Keyboard;
            this.button_shortcuts.Location = new System.Drawing.Point(0, 367);
            this.button_shortcuts.Margin = new System.Windows.Forms.Padding(0);
            this.button_shortcuts.Name = "button_shortcuts";
            this.button_shortcuts.Size = new System.Drawing.Size(64, 64);
            this.button_shortcuts.TabIndex = 4;
            this.button_shortcuts.UseVisualStyleBackColor = true;
            this.button_shortcuts.Click += new System.EventHandler(this.button_shortcuts_Click);
            // 
            // button_settings
            // 
            this.button_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Image = global::PythonCodeEditor.Properties.Resources.Settings;
            this.button_settings.Location = new System.Drawing.Point(0, 431);
            this.button_settings.Margin = new System.Windows.Forms.Padding(0);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(64, 64);
            this.button_settings.TabIndex = 3;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_console
            // 
            this.button_console.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_console.FlatAppearance.BorderSize = 0;
            this.button_console.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_console.Image = global::PythonCodeEditor.Properties.Resources.Console;
            this.button_console.Location = new System.Drawing.Point(0, 128);
            this.button_console.Margin = new System.Windows.Forms.Padding(0);
            this.button_console.Name = "button_console";
            this.button_console.Size = new System.Drawing.Size(64, 64);
            this.button_console.TabIndex = 2;
            this.button_console.UseVisualStyleBackColor = true;
            this.button_console.Click += new System.EventHandler(this.button_console_Click);
            // 
            // button_python
            // 
            this.button_python.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_python.FlatAppearance.BorderSize = 0;
            this.button_python.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_python.Image = global::PythonCodeEditor.Properties.Resources.Python;
            this.button_python.Location = new System.Drawing.Point(0, 64);
            this.button_python.Margin = new System.Windows.Forms.Padding(0);
            this.button_python.Name = "button_python";
            this.button_python.Size = new System.Drawing.Size(64, 64);
            this.button_python.TabIndex = 1;
            this.button_python.UseVisualStyleBackColor = true;
            this.button_python.Click += new System.EventHandler(this.button_python_Click);
            // 
            // button_run
            // 
            this.button_run.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_run.FlatAppearance.BorderSize = 0;
            this.button_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_run.Image = global::PythonCodeEditor.Properties.Resources.Run;
            this.button_run.Location = new System.Drawing.Point(0, 0);
            this.button_run.Margin = new System.Windows.Forms.Padding(0);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(64, 64);
            this.button_run.TabIndex = 0;
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // tab_main
            // 
            this.tab_main.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab_main.Controls.Add(this.tab_editor);
            this.tab_main.Controls.Add(this.tab_shortcuts);
            this.tab_main.Controls.Add(this.tab_settings);
            this.tab_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_main.ImageList = this.imageList_tabs;
            this.tab_main.ItemSize = new System.Drawing.Size(18, 18);
            this.tab_main.Location = new System.Drawing.Point(64, 0);
            this.tab_main.Margin = new System.Windows.Forms.Padding(0);
            this.tab_main.Multiline = true;
            this.tab_main.Name = "tab_main";
            this.tab_main.Padding = new System.Drawing.Point(0, 0);
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(936, 495);
            this.tab_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_main.TabIndex = 5;
            // 
            // tab_editor
            // 
            this.tab_editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tab_editor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tab_editor.Controls.Add(this.codeEditor);
            this.tab_editor.ImageIndex = 0;
            this.tab_editor.Location = new System.Drawing.Point(4, 4);
            this.tab_editor.Margin = new System.Windows.Forms.Padding(0);
            this.tab_editor.Name = "tab_editor";
            this.tab_editor.Size = new System.Drawing.Size(928, 469);
            this.tab_editor.TabIndex = 0;
            this.tab_editor.Text = "Editor";
            // 
            // codeEditor
            // 
            this.codeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.codeEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditor.ForeColor = System.Drawing.Color.White;
            this.codeEditor.Location = new System.Drawing.Point(0, 0);
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Size = new System.Drawing.Size(928, 469);
            this.codeEditor.TabIndex = 0;
            this.codeEditor.Text = "";
            this.codeEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeEditor_KeyDown);
            this.codeEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeEditor_KeyPress);
            this.codeEditor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codeEditor_KeyUp);
            this.codeEditor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.codeEditor_PreviewKeyDown);
            // 
            // tab_shortcuts
            // 
            this.tab_shortcuts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tab_shortcuts.Controls.Add(this.label_shortcuts);
            this.tab_shortcuts.ImageIndex = 0;
            this.tab_shortcuts.Location = new System.Drawing.Point(4, 4);
            this.tab_shortcuts.Name = "tab_shortcuts";
            this.tab_shortcuts.Padding = new System.Windows.Forms.Padding(3);
            this.tab_shortcuts.Size = new System.Drawing.Size(928, 469);
            this.tab_shortcuts.TabIndex = 1;
            this.tab_shortcuts.Text = "Shortcuts";
            // 
            // label_shortcuts
            // 
            this.label_shortcuts.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_shortcuts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_shortcuts.ForeColor = System.Drawing.SystemColors.Control;
            this.label_shortcuts.Location = new System.Drawing.Point(3, 3);
            this.label_shortcuts.Name = "label_shortcuts";
            this.label_shortcuts.Size = new System.Drawing.Size(922, 23);
            this.label_shortcuts.TabIndex = 0;
            this.label_shortcuts.Text = "shortcuts menu";
            this.label_shortcuts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tab_settings
            // 
            this.tab_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tab_settings.Controls.Add(this.tableLayoutPanel2);
            this.tab_settings.Controls.Add(this.table_settings);
            this.tab_settings.Controls.Add(this.label_settings);
            this.tab_settings.ImageIndex = 0;
            this.tab_settings.Location = new System.Drawing.Point(4, 4);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(928, 469);
            this.tab_settings.TabIndex = 2;
            this.tab_settings.Text = "Settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label_example, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(463, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 440);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label_example
            // 
            this.label_example.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_example.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_example.ForeColor = System.Drawing.SystemColors.Control;
            this.label_example.Location = new System.Drawing.Point(3, 0);
            this.label_example.Name = "label_example";
            this.label_example.Size = new System.Drawing.Size(456, 227);
            this.label_example.TabIndex = 0;
            this.label_example.Text = "print(\"hello world\")\r\n\r\nfor i in range(10):\r\n    print(i)\r\n    ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_reset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 207);
            this.panel2.TabIndex = 1;
            // 
            // button_reset
            // 
            this.button_reset.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.ForeColor = System.Drawing.SystemColors.Control;
            this.button_reset.Location = new System.Drawing.Point(0, 0);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(456, 58);
            this.button_reset.TabIndex = 2;
            this.button_reset.Text = "default";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // table_settings
            // 
            this.table_settings.ColumnCount = 2;
            this.table_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_settings.Controls.Add(this.label_fontColor, 0, 0);
            this.table_settings.Controls.Add(this.button_fontColor, 1, 0);
            this.table_settings.Controls.Add(this.button_bgColor, 1, 1);
            this.table_settings.Controls.Add(this.button_font, 1, 2);
            this.table_settings.Controls.Add(this.label_bgColor, 0, 1);
            this.table_settings.Controls.Add(this.label_font, 0, 2);
            this.table_settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.table_settings.Location = new System.Drawing.Point(3, 26);
            this.table_settings.Name = "table_settings";
            this.table_settings.RowCount = 4;
            this.table_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_settings.Size = new System.Drawing.Size(460, 440);
            this.table_settings.TabIndex = 2;
            // 
            // label_fontColor
            // 
            this.label_fontColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fontColor.ForeColor = System.Drawing.SystemColors.Control;
            this.label_fontColor.Location = new System.Drawing.Point(3, 0);
            this.label_fontColor.Name = "label_fontColor";
            this.label_fontColor.Size = new System.Drawing.Size(225, 64);
            this.label_fontColor.TabIndex = 0;
            this.label_fontColor.Text = "Font color";
            this.label_fontColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_fontColor
            // 
            this.button_fontColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_fontColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fontColor.ForeColor = System.Drawing.SystemColors.Control;
            this.button_fontColor.Location = new System.Drawing.Point(234, 3);
            this.button_fontColor.Name = "button_fontColor";
            this.button_fontColor.Size = new System.Drawing.Size(223, 58);
            this.button_fontColor.TabIndex = 1;
            this.button_fontColor.Text = "select";
            this.button_fontColor.UseVisualStyleBackColor = true;
            this.button_fontColor.Click += new System.EventHandler(this.button_fontColor_Click);
            // 
            // button_bgColor
            // 
            this.button_bgColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_bgColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bgColor.ForeColor = System.Drawing.SystemColors.Control;
            this.button_bgColor.Location = new System.Drawing.Point(234, 67);
            this.button_bgColor.Name = "button_bgColor";
            this.button_bgColor.Size = new System.Drawing.Size(223, 58);
            this.button_bgColor.TabIndex = 2;
            this.button_bgColor.Text = "select";
            this.button_bgColor.UseVisualStyleBackColor = true;
            this.button_bgColor.Click += new System.EventHandler(this.button_bgColor_Click);
            // 
            // button_font
            // 
            this.button_font.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_font.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_font.ForeColor = System.Drawing.SystemColors.Control;
            this.button_font.Location = new System.Drawing.Point(234, 131);
            this.button_font.Name = "button_font";
            this.button_font.Size = new System.Drawing.Size(223, 58);
            this.button_font.TabIndex = 3;
            this.button_font.Text = "select";
            this.button_font.UseVisualStyleBackColor = true;
            this.button_font.Click += new System.EventHandler(this.button_font_Click);
            // 
            // label_bgColor
            // 
            this.label_bgColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_bgColor.ForeColor = System.Drawing.SystemColors.Control;
            this.label_bgColor.Location = new System.Drawing.Point(3, 64);
            this.label_bgColor.Name = "label_bgColor";
            this.label_bgColor.Size = new System.Drawing.Size(225, 64);
            this.label_bgColor.TabIndex = 4;
            this.label_bgColor.Text = "Background color";
            this.label_bgColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_font
            // 
            this.label_font.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_font.ForeColor = System.Drawing.SystemColors.Control;
            this.label_font.Location = new System.Drawing.Point(3, 128);
            this.label_font.Name = "label_font";
            this.label_font.Size = new System.Drawing.Size(225, 64);
            this.label_font.TabIndex = 5;
            this.label_font.Text = "Font";
            this.label_font.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_settings
            // 
            this.label_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_settings.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_settings.ForeColor = System.Drawing.SystemColors.Control;
            this.label_settings.Location = new System.Drawing.Point(3, 3);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(922, 23);
            this.label_settings.TabIndex = 1;
            this.label_settings.Text = "settings";
            this.label_settings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList_tabs
            // 
            this.imageList_tabs.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_tabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_tabs.ImageStream")));
            this.imageList_tabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_tabs.Images.SetKeyName(0, "tab.png");
            // 
            // colorDialog_font
            // 
            this.colorDialog_font.Color = System.Drawing.SystemColors.Control;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font color";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(234, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.SystemColors.Control;
            // 
            // colorDialog_bg
            // 
            this.colorDialog_bg.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.SystemColors.Control;
            this.fontDialog.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1000, 495);
            this.Controls.Add(this.tab_main);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainWindow";
            this.Text = "PySharp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.tab_editor.ResumeLayout(false);
            this.tab_shortcuts.ResumeLayout(false);
            this.tab_settings.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.table_settings.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button button_run;
        private Button button_settings;
        private Button button_console;
        private Button button_python;
        private Button button_shortcuts;
        private TabControl tab_main;
        private TabPage tab_editor;
        private TabPage tab_shortcuts;
        private Button button_editor;
        private TabPage tab_settings;
        private Label label_shortcuts;
        private Label label_settings;
        private ImageList imageList_tabs;
        private TableLayoutPanel table_settings;
        private Label label_fontColor;
        private Button button_fontColor;
        private ColorDialog colorDialog_font;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button button1;
        private Label label_example;
        private Button button_bgColor;
        private Button button_font;
        private Label label_bgColor;
        private Label label_font;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog_bg;
        private FontDialog fontDialog;
        private Panel panel2;
        private Button button_reset;
        private RichTextBox codeEditor;
    }
}