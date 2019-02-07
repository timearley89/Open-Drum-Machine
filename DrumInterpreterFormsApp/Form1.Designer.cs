namespace DrumInterpreterFormsApp
{
    partial class frmDrum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpDrum1 = new System.Windows.Forms.GroupBox();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.txtDrum1 = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.grpDrum2 = new System.Windows.Forms.GroupBox();
            this.btnPlay2 = new System.Windows.Forms.Button();
            this.txtDrum2 = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.grpDrum3 = new System.Windows.Forms.GroupBox();
            this.btnPlay3 = new System.Windows.Forms.Button();
            this.txtDrum3 = new System.Windows.Forms.TextBox();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.grpDrum4 = new System.Windows.Forms.GroupBox();
            this.btnPlay4 = new System.Windows.Forms.Button();
            this.txtDrum4 = new System.Windows.Forms.TextBox();
            this.btnBrowse4 = new System.Windows.Forms.Button();
            this.grpDrum5 = new System.Windows.Forms.GroupBox();
            this.btnPlay5 = new System.Windows.Forms.Button();
            this.txtDrum5 = new System.Windows.Forms.TextBox();
            this.btnBrowse5 = new System.Windows.Forms.Button();
            this.grpDrum6 = new System.Windows.Forms.GroupBox();
            this.btnPlay6 = new System.Windows.Forms.Button();
            this.txtDrum6 = new System.Windows.Forms.TextBox();
            this.btnBrowse6 = new System.Windows.Forms.Button();
            this.grpDrum7 = new System.Windows.Forms.GroupBox();
            this.btnPlay7 = new System.Windows.Forms.Button();
            this.txtDrum7 = new System.Windows.Forms.TextBox();
            this.btnBrowse7 = new System.Windows.Forms.Button();
            this.grpDrum8 = new System.Windows.Forms.GroupBox();
            this.btnPlay8 = new System.Windows.Forms.Button();
            this.txtDrum8 = new System.Windows.Forms.TextBox();
            this.btnBrowse8 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpDrum1.SuspendLayout();
            this.grpDrum2.SuspendLayout();
            this.grpDrum3.SuspendLayout();
            this.grpDrum4.SuspendLayout();
            this.grpDrum5.SuspendLayout();
            this.grpDrum6.SuspendLayout();
            this.grpDrum7.SuspendLayout();
            this.grpDrum8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDrum1
            // 
            this.grpDrum1.Controls.Add(this.btnPlay1);
            this.grpDrum1.Controls.Add(this.txtDrum1);
            this.grpDrum1.Controls.Add(this.btnBrowse1);
            this.grpDrum1.ForeColor = System.Drawing.Color.White;
            this.grpDrum1.Location = new System.Drawing.Point(12, 44);
            this.grpDrum1.Name = "grpDrum1";
            this.grpDrum1.Size = new System.Drawing.Size(200, 100);
            this.grpDrum1.TabIndex = 0;
            this.grpDrum1.TabStop = false;
            this.grpDrum1.Text = "Drum 1";
            // 
            // btnPlay1
            // 
            this.btnPlay1.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay1.Location = new System.Drawing.Point(150, 71);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(44, 23);
            this.btnPlay1.TabIndex = 2;
            this.btnPlay1.Text = "Play";
            this.btnPlay1.UseVisualStyleBackColor = false;
            // 
            // txtDrum1
            // 
            this.txtDrum1.Location = new System.Drawing.Point(6, 20);
            this.txtDrum1.Multiline = true;
            this.txtDrum1.Name = "txtDrum1";
            this.txtDrum1.ReadOnly = true;
            this.txtDrum1.Size = new System.Drawing.Size(187, 45);
            this.txtDrum1.TabIndex = 1;
            this.txtDrum1.Text = "No Sample Loaded";
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.BackColor = System.Drawing.Color.Firebrick;
            this.btnBrowse1.Location = new System.Drawing.Point(7, 71);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse1.TabIndex = 0;
            this.btnBrowse1.Text = "Browse...";
            this.btnBrowse1.UseVisualStyleBackColor = false;
            // 
            // grpDrum2
            // 
            this.grpDrum2.Controls.Add(this.btnPlay2);
            this.grpDrum2.Controls.Add(this.txtDrum2);
            this.grpDrum2.Controls.Add(this.btnBrowse2);
            this.grpDrum2.ForeColor = System.Drawing.Color.White;
            this.grpDrum2.Location = new System.Drawing.Point(12, 151);
            this.grpDrum2.Name = "grpDrum2";
            this.grpDrum2.Size = new System.Drawing.Size(200, 100);
            this.grpDrum2.TabIndex = 1;
            this.grpDrum2.TabStop = false;
            this.grpDrum2.Text = "Drum 2";
            // 
            // btnPlay2
            // 
            this.btnPlay2.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay2.Location = new System.Drawing.Point(150, 71);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(44, 23);
            this.btnPlay2.TabIndex = 4;
            this.btnPlay2.Text = "Play";
            this.btnPlay2.UseVisualStyleBackColor = false;
            // 
            // txtDrum2
            // 
            this.txtDrum2.Location = new System.Drawing.Point(7, 20);
            this.txtDrum2.Multiline = true;
            this.txtDrum2.Name = "txtDrum2";
            this.txtDrum2.ReadOnly = true;
            this.txtDrum2.Size = new System.Drawing.Size(187, 45);
            this.txtDrum2.TabIndex = 2;
            this.txtDrum2.Text = "No Sample Loaded";
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.BackColor = System.Drawing.Color.Firebrick;
            this.btnBrowse2.Location = new System.Drawing.Point(7, 71);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 0;
            this.btnBrowse2.Text = "Browse...";
            this.btnBrowse2.UseVisualStyleBackColor = false;
            // 
            // grpDrum3
            // 
            this.grpDrum3.Controls.Add(this.btnPlay3);
            this.grpDrum3.Controls.Add(this.txtDrum3);
            this.grpDrum3.Controls.Add(this.btnBrowse3);
            this.grpDrum3.ForeColor = System.Drawing.Color.White;
            this.grpDrum3.Location = new System.Drawing.Point(12, 258);
            this.grpDrum3.Name = "grpDrum3";
            this.grpDrum3.Size = new System.Drawing.Size(200, 100);
            this.grpDrum3.TabIndex = 2;
            this.grpDrum3.TabStop = false;
            this.grpDrum3.Text = "Drum 3";
            // 
            // btnPlay3
            // 
            this.btnPlay3.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay3.Location = new System.Drawing.Point(150, 71);
            this.btnPlay3.Name = "btnPlay3";
            this.btnPlay3.Size = new System.Drawing.Size(44, 23);
            this.btnPlay3.TabIndex = 6;
            this.btnPlay3.Text = "Play";
            this.btnPlay3.UseVisualStyleBackColor = false;
            // 
            // txtDrum3
            // 
            this.txtDrum3.Location = new System.Drawing.Point(7, 19);
            this.txtDrum3.Multiline = true;
            this.txtDrum3.Name = "txtDrum3";
            this.txtDrum3.ReadOnly = true;
            this.txtDrum3.Size = new System.Drawing.Size(187, 45);
            this.txtDrum3.TabIndex = 3;
            this.txtDrum3.Text = "No Sample Loaded";
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.BackColor = System.Drawing.Color.Firebrick;
            this.btnBrowse3.Location = new System.Drawing.Point(7, 71);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse3.TabIndex = 0;
            this.btnBrowse3.Text = "Browse...";
            this.btnBrowse3.UseVisualStyleBackColor = false;
            // 
            // grpDrum4
            // 
            this.grpDrum4.Controls.Add(this.btnPlay4);
            this.grpDrum4.Controls.Add(this.txtDrum4);
            this.grpDrum4.Controls.Add(this.btnBrowse4);
            this.grpDrum4.ForeColor = System.Drawing.Color.White;
            this.grpDrum4.Location = new System.Drawing.Point(11, 364);
            this.grpDrum4.Name = "grpDrum4";
            this.grpDrum4.Size = new System.Drawing.Size(200, 100);
            this.grpDrum4.TabIndex = 3;
            this.grpDrum4.TabStop = false;
            this.grpDrum4.Text = "Drum 4";
            // 
            // btnPlay4
            // 
            this.btnPlay4.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay4.Location = new System.Drawing.Point(151, 71);
            this.btnPlay4.Name = "btnPlay4";
            this.btnPlay4.Size = new System.Drawing.Size(44, 23);
            this.btnPlay4.TabIndex = 8;
            this.btnPlay4.Text = "Play";
            this.btnPlay4.UseVisualStyleBackColor = false;
            // 
            // txtDrum4
            // 
            this.txtDrum4.Location = new System.Drawing.Point(8, 19);
            this.txtDrum4.Multiline = true;
            this.txtDrum4.Name = "txtDrum4";
            this.txtDrum4.ReadOnly = true;
            this.txtDrum4.Size = new System.Drawing.Size(187, 45);
            this.txtDrum4.TabIndex = 5;
            this.txtDrum4.Text = "No Sample Loaded";
            // 
            // btnBrowse4
            // 
            this.btnBrowse4.BackColor = System.Drawing.Color.Firebrick;
            this.btnBrowse4.Location = new System.Drawing.Point(7, 71);
            this.btnBrowse4.Name = "btnBrowse4";
            this.btnBrowse4.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse4.TabIndex = 0;
            this.btnBrowse4.Text = "Browse...";
            this.btnBrowse4.UseVisualStyleBackColor = false;
            // 
            // grpDrum5
            // 
            this.grpDrum5.Controls.Add(this.btnPlay5);
            this.grpDrum5.Controls.Add(this.txtDrum5);
            this.grpDrum5.Controls.Add(this.btnBrowse5);
            this.grpDrum5.ForeColor = System.Drawing.Color.White;
            this.grpDrum5.Location = new System.Drawing.Point(219, 44);
            this.grpDrum5.Name = "grpDrum5";
            this.grpDrum5.Size = new System.Drawing.Size(200, 100);
            this.grpDrum5.TabIndex = 4;
            this.grpDrum5.TabStop = false;
            this.grpDrum5.Text = "Drum 5";
            // 
            // btnPlay5
            // 
            this.btnPlay5.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay5.Location = new System.Drawing.Point(150, 71);
            this.btnPlay5.Name = "btnPlay5";
            this.btnPlay5.Size = new System.Drawing.Size(44, 23);
            this.btnPlay5.TabIndex = 3;
            this.btnPlay5.Text = "Play";
            this.btnPlay5.UseVisualStyleBackColor = false;
            // 
            // txtDrum5
            // 
            this.txtDrum5.Location = new System.Drawing.Point(7, 19);
            this.txtDrum5.Multiline = true;
            this.txtDrum5.Name = "txtDrum5";
            this.txtDrum5.ReadOnly = true;
            this.txtDrum5.Size = new System.Drawing.Size(187, 45);
            this.txtDrum5.TabIndex = 2;
            this.txtDrum5.Text = "No Sample Loaded";
            // 
            // btnBrowse5
            // 
            this.btnBrowse5.BackColor = System.Drawing.Color.Firebrick;
            this.btnBrowse5.Location = new System.Drawing.Point(7, 71);
            this.btnBrowse5.Name = "btnBrowse5";
            this.btnBrowse5.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse5.TabIndex = 0;
            this.btnBrowse5.Text = "Browse...";
            this.btnBrowse5.UseVisualStyleBackColor = false;
            // 
            // grpDrum6
            // 
            this.grpDrum6.Controls.Add(this.btnPlay6);
            this.grpDrum6.Controls.Add(this.txtDrum6);
            this.grpDrum6.Controls.Add(this.btnBrowse6);
            this.grpDrum6.ForeColor = System.Drawing.Color.White;
            this.grpDrum6.Location = new System.Drawing.Point(219, 151);
            this.grpDrum6.Name = "grpDrum6";
            this.grpDrum6.Size = new System.Drawing.Size(200, 100);
            this.grpDrum6.TabIndex = 5;
            this.grpDrum6.TabStop = false;
            this.grpDrum6.Text = "Drum 6";
            // 
            // btnPlay6
            // 
            this.btnPlay6.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay6.Location = new System.Drawing.Point(150, 71);
            this.btnPlay6.Name = "btnPlay6";
            this.btnPlay6.Size = new System.Drawing.Size(44, 23);
            this.btnPlay6.TabIndex = 5;
            this.btnPlay6.Text = "Play";
            this.btnPlay6.UseVisualStyleBackColor = false;
            // 
            // txtDrum6
            // 
            this.txtDrum6.Location = new System.Drawing.Point(7, 19);
            this.txtDrum6.Multiline = true;
            this.txtDrum6.Name = "txtDrum6";
            this.txtDrum6.ReadOnly = true;
            this.txtDrum6.Size = new System.Drawing.Size(187, 45);
            this.txtDrum6.TabIndex = 2;
            this.txtDrum6.Text = "No Sample Loaded";
            // 
            // btnBrowse6
            // 
            this.btnBrowse6.BackColor = System.Drawing.Color.Firebrick;
            this.btnBrowse6.Location = new System.Drawing.Point(7, 71);
            this.btnBrowse6.Name = "btnBrowse6";
            this.btnBrowse6.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse6.TabIndex = 0;
            this.btnBrowse6.Text = "Browse...";
            this.btnBrowse6.UseVisualStyleBackColor = false;
            // 
            // grpDrum7
            // 
            this.grpDrum7.Controls.Add(this.btnPlay7);
            this.grpDrum7.Controls.Add(this.txtDrum7);
            this.grpDrum7.Controls.Add(this.btnBrowse7);
            this.grpDrum7.ForeColor = System.Drawing.Color.White;
            this.grpDrum7.Location = new System.Drawing.Point(219, 258);
            this.grpDrum7.Name = "grpDrum7";
            this.grpDrum7.Size = new System.Drawing.Size(200, 100);
            this.grpDrum7.TabIndex = 6;
            this.grpDrum7.TabStop = false;
            this.grpDrum7.Text = "Drum 7";
            // 
            // btnPlay7
            // 
            this.btnPlay7.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay7.Location = new System.Drawing.Point(150, 71);
            this.btnPlay7.Name = "btnPlay7";
            this.btnPlay7.Size = new System.Drawing.Size(44, 23);
            this.btnPlay7.TabIndex = 7;
            this.btnPlay7.Text = "Play";
            this.btnPlay7.UseVisualStyleBackColor = false;
            // 
            // txtDrum7
            // 
            this.txtDrum7.Location = new System.Drawing.Point(7, 19);
            this.txtDrum7.Multiline = true;
            this.txtDrum7.Name = "txtDrum7";
            this.txtDrum7.ReadOnly = true;
            this.txtDrum7.Size = new System.Drawing.Size(187, 45);
            this.txtDrum7.TabIndex = 4;
            this.txtDrum7.Text = "No Sample Loaded";
            // 
            // btnBrowse7
            // 
            this.btnBrowse7.BackColor = System.Drawing.Color.Firebrick;
            this.btnBrowse7.Location = new System.Drawing.Point(7, 71);
            this.btnBrowse7.Name = "btnBrowse7";
            this.btnBrowse7.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse7.TabIndex = 0;
            this.btnBrowse7.Text = "Browse...";
            this.btnBrowse7.UseVisualStyleBackColor = false;
            // 
            // grpDrum8
            // 
            this.grpDrum8.Controls.Add(this.btnPlay8);
            this.grpDrum8.Controls.Add(this.txtDrum8);
            this.grpDrum8.Controls.Add(this.btnBrowse8);
            this.grpDrum8.ForeColor = System.Drawing.Color.White;
            this.grpDrum8.Location = new System.Drawing.Point(218, 365);
            this.grpDrum8.Name = "grpDrum8";
            this.grpDrum8.Size = new System.Drawing.Size(200, 100);
            this.grpDrum8.TabIndex = 7;
            this.grpDrum8.TabStop = false;
            this.grpDrum8.Text = "Drum 8";
            // 
            // btnPlay8
            // 
            this.btnPlay8.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay8.Location = new System.Drawing.Point(151, 70);
            this.btnPlay8.Name = "btnPlay8";
            this.btnPlay8.Size = new System.Drawing.Size(44, 23);
            this.btnPlay8.TabIndex = 9;
            this.btnPlay8.Text = "Play";
            this.btnPlay8.UseVisualStyleBackColor = false;
            // 
            // txtDrum8
            // 
            this.txtDrum8.Location = new System.Drawing.Point(8, 18);
            this.txtDrum8.Multiline = true;
            this.txtDrum8.Name = "txtDrum8";
            this.txtDrum8.ReadOnly = true;
            this.txtDrum8.Size = new System.Drawing.Size(187, 45);
            this.txtDrum8.TabIndex = 4;
            this.txtDrum8.Text = "No Sample Loaded";
            // 
            // btnBrowse8
            // 
            this.btnBrowse8.BackColor = System.Drawing.Color.Firebrick;
            this.btnBrowse8.Location = new System.Drawing.Point(8, 70);
            this.btnBrowse8.Name = "btnBrowse8";
            this.btnBrowse8.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse8.TabIndex = 0;
            this.btnBrowse8.Text = "Browse...";
            this.btnBrowse8.UseVisualStyleBackColor = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "odm";
            // 
            // openSaveFile
            // 
            this.openSaveFile.DefaultExt = "odm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.cOMPortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide...";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cOMPortToolStripMenuItem
            // 
            this.cOMPortToolStripMenuItem.Name = "cOMPortToolStripMenuItem";
            this.cOMPortToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.cOMPortToolStripMenuItem.Text = "COM Port...";
            this.cOMPortToolStripMenuItem.Click += new System.EventHandler(this.cOMPortToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // frmDrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(436, 480);
            this.Controls.Add(this.grpDrum8);
            this.Controls.Add(this.grpDrum7);
            this.Controls.Add(this.grpDrum6);
            this.Controls.Add(this.grpDrum5);
            this.Controls.Add(this.grpDrum4);
            this.Controls.Add(this.grpDrum3);
            this.Controls.Add(this.grpDrum2);
            this.Controls.Add(this.grpDrum1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmDrum";
            this.Text = "OpenDrumMachine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDrum1.ResumeLayout(false);
            this.grpDrum1.PerformLayout();
            this.grpDrum2.ResumeLayout(false);
            this.grpDrum2.PerformLayout();
            this.grpDrum3.ResumeLayout(false);
            this.grpDrum3.PerformLayout();
            this.grpDrum4.ResumeLayout(false);
            this.grpDrum4.PerformLayout();
            this.grpDrum5.ResumeLayout(false);
            this.grpDrum5.PerformLayout();
            this.grpDrum6.ResumeLayout(false);
            this.grpDrum6.PerformLayout();
            this.grpDrum7.ResumeLayout(false);
            this.grpDrum7.PerformLayout();
            this.grpDrum8.ResumeLayout(false);
            this.grpDrum8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDrum1;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.TextBox txtDrum1;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.GroupBox grpDrum2;
        private System.Windows.Forms.Button btnPlay2;
        private System.Windows.Forms.TextBox txtDrum2;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.GroupBox grpDrum3;
        private System.Windows.Forms.Button btnPlay3;
        private System.Windows.Forms.TextBox txtDrum3;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.GroupBox grpDrum4;
        private System.Windows.Forms.Button btnPlay4;
        private System.Windows.Forms.TextBox txtDrum4;
        private System.Windows.Forms.Button btnBrowse4;
        private System.Windows.Forms.GroupBox grpDrum5;
        private System.Windows.Forms.Button btnPlay5;
        private System.Windows.Forms.TextBox txtDrum5;
        private System.Windows.Forms.Button btnBrowse5;
        private System.Windows.Forms.GroupBox grpDrum6;
        private System.Windows.Forms.Button btnPlay6;
        private System.Windows.Forms.TextBox txtDrum6;
        private System.Windows.Forms.Button btnBrowse6;
        private System.Windows.Forms.GroupBox grpDrum7;
        private System.Windows.Forms.Button btnPlay7;
        private System.Windows.Forms.TextBox txtDrum7;
        private System.Windows.Forms.Button btnBrowse7;
        private System.Windows.Forms.GroupBox grpDrum8;
        private System.Windows.Forms.Button btnPlay8;
        private System.Windows.Forms.TextBox txtDrum8;
        private System.Windows.Forms.Button btnBrowse8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openSaveFile;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cOMPortToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

