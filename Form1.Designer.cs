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
            this.codeEditor = new System.Windows.Forms.TextBox();
            this.tab_shortcuts = new System.Windows.Forms.TabPage();
            this.label_shortcuts = new System.Windows.Forms.Label();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.label_settings = new System.Windows.Forms.Label();
            this.imageList_tabs = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tab_editor.SuspendLayout();
            this.tab_shortcuts.SuspendLayout();
            this.tab_settings.SuspendLayout();
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
            this.button_console.Click += new System.EventHandler(this.Button_console_Click);
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
            this.button_python.Click += new System.EventHandler(this.Button_python_Click);
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
            this.button_run.Click += new System.EventHandler(this.Button_run_Click);
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
            this.codeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.codeEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditor.ForeColor = System.Drawing.SystemColors.Control;
            this.codeEditor.Location = new System.Drawing.Point(0, 0);
            this.codeEditor.Margin = new System.Windows.Forms.Padding(0);
            this.codeEditor.Multiline = true;
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Size = new System.Drawing.Size(928, 469);
            this.codeEditor.TabIndex = 4;
            this.codeEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeEditor_KeyDown);
            this.codeEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeEditor_KeyPress);
            this.codeEditor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CodeEditor_PreviewKeyDown);
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
            this.tab_settings.Controls.Add(this.label_settings);
            this.tab_settings.ImageIndex = 0;
            this.tab_settings.Location = new System.Drawing.Point(4, 4);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(928, 469);
            this.tab_settings.TabIndex = 2;
            this.tab_settings.Text = "Settings";
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
            this.panel1.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.tab_editor.ResumeLayout(false);
            this.tab_editor.PerformLayout();
            this.tab_shortcuts.ResumeLayout(false);
            this.tab_settings.ResumeLayout(false);
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
        private TextBox codeEditor;
        private Button button_editor;
        private TabPage tab_settings;
        private Label label_shortcuts;
        private Label label_settings;
        private ImageList imageList_tabs;
    }
}