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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_console = new System.Windows.Forms.Button();
            this.button_python = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.codeEditor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
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
            // codeEditor
            // 
            this.codeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.codeEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditor.ForeColor = System.Drawing.SystemColors.Control;
            this.codeEditor.Location = new System.Drawing.Point(64, 0);
            this.codeEditor.Multiline = true;
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Size = new System.Drawing.Size(936, 495);
            this.codeEditor.TabIndex = 4;
            this.codeEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeEditor_KeyDown);
            this.codeEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeEditor_KeyPress);
            this.codeEditor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CodeEditor_PreviewKeyDown);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 495);
            this.Controls.Add(this.codeEditor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainWindow";
            this.Text = "PySharp";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private TextBox codeEditor;
        private Button button_run;
        private Button button_settings;
        private Button button_console;
        private Button button_python;
    }
}