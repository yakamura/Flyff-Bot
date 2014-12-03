namespace macro
{
    partial class Form1
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
            this.boxWindowTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLockOn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowWindow = new System.Windows.Forms.Button();
            this.btnHideWindow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSound1 = new System.Windows.Forms.Label();
            this.chkStart1 = new System.Windows.Forms.CheckBox();
            this.chkHotKey1 = new System.Windows.Forms.CheckBox();
            this.boxHotKey1 = new System.Windows.Forms.TextBox();
            this.lblDelay1 = new System.Windows.Forms.Label();
            this.boxDelay1 = new System.Windows.Forms.TextBox();
            this.btnStartMacro1 = new System.Windows.Forms.Button();
            this.btnClearMacro1 = new System.Windows.Forms.Button();
            this.boxMacro1 = new System.Windows.Forms.TextBox();
            this.macro1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblSound2 = new System.Windows.Forms.Label();
            this.chkStart2 = new System.Windows.Forms.CheckBox();
            this.chkHotKey2 = new System.Windows.Forms.CheckBox();
            this.boxHotKey2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxDelay2 = new System.Windows.Forms.TextBox();
            this.btnStartMacro2 = new System.Windows.Forms.Button();
            this.btnClearMacro2 = new System.Windows.Forms.Button();
            this.boxMacro2 = new System.Windows.Forms.TextBox();
            this.back1 = new System.ComponentModel.BackgroundWorker();
            this.macro2 = new System.Windows.Forms.Timer(this.components);
            this.back2 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxWindowTitle
            // 
            this.boxWindowTitle.Location = new System.Drawing.Point(84, 19);
            this.boxWindowTitle.Name = "boxWindowTitle";
            this.boxWindowTitle.Size = new System.Drawing.Size(125, 21);
            this.boxWindowTitle.TabIndex = 0;
            this.boxWindowTitle.TextChanged += new System.EventHandler(this.boxWindowTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Window Title:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxWindowTitle);
            this.groupBox1.Controls.Add(this.btnLockOn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // btnLockOn
            // 
            this.btnLockOn.Location = new System.Drawing.Point(215, 17);
            this.btnLockOn.Name = "btnLockOn";
            this.btnLockOn.Size = new System.Drawing.Size(61, 23);
            this.btnLockOn.TabIndex = 2;
            this.btnLockOn.Text = "Lock on";
            this.btnLockOn.UseVisualStyleBackColor = true;
            this.btnLockOn.Click += new System.EventHandler(this.btnLockOn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowWindow);
            this.groupBox2.Controls.Add(this.btnHideWindow);
            this.groupBox2.Location = new System.Drawing.Point(11, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // btnShowWindow
            // 
            this.btnShowWindow.Location = new System.Drawing.Point(145, 19);
            this.btnShowWindow.Name = "btnShowWindow";
            this.btnShowWindow.Size = new System.Drawing.Size(132, 23);
            this.btnShowWindow.TabIndex = 7;
            this.btnShowWindow.Text = "Show";
            this.btnShowWindow.UseVisualStyleBackColor = true;
            this.btnShowWindow.Click += new System.EventHandler(this.btnShowWindow_Click);
            // 
            // btnHideWindow
            // 
            this.btnHideWindow.Location = new System.Drawing.Point(9, 19);
            this.btnHideWindow.Name = "btnHideWindow";
            this.btnHideWindow.Size = new System.Drawing.Size(132, 23);
            this.btnHideWindow.TabIndex = 6;
            this.btnHideWindow.Text = "Hide";
            this.btnHideWindow.UseVisualStyleBackColor = true;
            this.btnHideWindow.Click += new System.EventHandler(this.btnHideWindow_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lblDelay1);
            this.groupBox3.Controls.Add(this.boxDelay1);
            this.groupBox3.Controls.Add(this.btnStartMacro1);
            this.groupBox3.Controls.Add(this.btnClearMacro1);
            this.groupBox3.Controls.Add(this.boxMacro1);
            this.groupBox3.Location = new System.Drawing.Point(11, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 153);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Macro 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSound1);
            this.groupBox4.Controls.Add(this.chkStart1);
            this.groupBox4.Controls.Add(this.chkHotKey1);
            this.groupBox4.Controls.Add(this.boxHotKey1);
            this.groupBox4.Location = new System.Drawing.Point(150, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 67);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hotkey";
            // 
            // lblSound1
            // 
            this.lblSound1.AutoSize = true;
            this.lblSound1.Location = new System.Drawing.Point(106, 45);
            this.lblSound1.Name = "lblSound1";
            this.lblSound1.Size = new System.Drawing.Size(16, 13);
            this.lblSound1.TabIndex = 10;
            this.lblSound1.Text = "♫";
            this.lblSound1.Click += new System.EventHandler(this.lblSound1_Click);
            // 
            // chkStart1
            // 
            this.chkStart1.AutoSize = true;
            this.chkStart1.Location = new System.Drawing.Point(6, 44);
            this.chkStart1.Name = "chkStart1";
            this.chkStart1.Size = new System.Drawing.Size(96, 17);
            this.chkStart1.TabIndex = 8;
            this.chkStart1.Text = "Start Auto Cast";
            this.chkStart1.UseVisualStyleBackColor = true;
            // 
            // chkHotKey1
            // 
            this.chkHotKey1.AutoSize = true;
            this.chkHotKey1.Location = new System.Drawing.Point(6, 20);
            this.chkHotKey1.Name = "chkHotKey1";
            this.chkHotKey1.Size = new System.Drawing.Size(15, 14);
            this.chkHotKey1.TabIndex = 7;
            this.chkHotKey1.UseVisualStyleBackColor = true;
            // 
            // boxHotKey1
            // 
            this.boxHotKey1.Location = new System.Drawing.Point(27, 17);
            this.boxHotKey1.Name = "boxHotKey1";
            this.boxHotKey1.ReadOnly = true;
            this.boxHotKey1.Size = new System.Drawing.Size(93, 21);
            this.boxHotKey1.TabIndex = 1;
            this.boxHotKey1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxHotKey1_KeyDown);
            // 
            // lblDelay1
            // 
            this.lblDelay1.AutoSize = true;
            this.lblDelay1.Location = new System.Drawing.Point(11, 125);
            this.lblDelay1.Name = "lblDelay1";
            this.lblDelay1.Size = new System.Drawing.Size(37, 13);
            this.lblDelay1.TabIndex = 6;
            this.lblDelay1.Text = "Delay:";
            this.lblDelay1.Click += new System.EventHandler(this.lblDelay1_Click);
            // 
            // boxDelay1
            // 
            this.boxDelay1.Location = new System.Drawing.Point(60, 122);
            this.boxDelay1.Name = "boxDelay1";
            this.boxDelay1.Size = new System.Drawing.Size(81, 21);
            this.boxDelay1.TabIndex = 5;
            this.boxDelay1.Text = "100";
            // 
            // btnStartMacro1
            // 
            this.btnStartMacro1.Location = new System.Drawing.Point(151, 122);
            this.btnStartMacro1.Name = "btnStartMacro1";
            this.btnStartMacro1.Size = new System.Drawing.Size(126, 23);
            this.btnStartMacro1.TabIndex = 4;
            this.btnStartMacro1.Text = "Start Auto Cast";
            this.btnStartMacro1.UseVisualStyleBackColor = true;
            this.btnStartMacro1.Click += new System.EventHandler(this.btnStartMacro1_Click);
            // 
            // btnClearMacro1
            // 
            this.btnClearMacro1.Location = new System.Drawing.Point(151, 93);
            this.btnClearMacro1.Name = "btnClearMacro1";
            this.btnClearMacro1.Size = new System.Drawing.Size(126, 23);
            this.btnClearMacro1.TabIndex = 3;
            this.btnClearMacro1.Text = "Clear Macro";
            this.btnClearMacro1.UseVisualStyleBackColor = true;
            this.btnClearMacro1.Click += new System.EventHandler(this.btnClearMacro1_Click);
            // 
            // boxMacro1
            // 
            this.boxMacro1.Location = new System.Drawing.Point(9, 20);
            this.boxMacro1.Multiline = true;
            this.boxMacro1.Name = "boxMacro1";
            this.boxMacro1.ReadOnly = true;
            this.boxMacro1.Size = new System.Drawing.Size(132, 96);
            this.boxMacro1.TabIndex = 0;
            this.boxMacro1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxMacro1_KeyDown);
            // 
            // macro1
            // 
            this.macro1.Enabled = true;
            this.macro1.Tick += new System.EventHandler(this.macro1_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.boxDelay2);
            this.groupBox5.Controls.Add(this.btnStartMacro2);
            this.groupBox5.Controls.Add(this.btnClearMacro2);
            this.groupBox5.Controls.Add(this.boxMacro2);
            this.groupBox5.Location = new System.Drawing.Point(12, 287);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 153);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Macro 2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblSound2);
            this.groupBox6.Controls.Add(this.chkStart2);
            this.groupBox6.Controls.Add(this.chkHotKey2);
            this.groupBox6.Controls.Add(this.boxHotKey2);
            this.groupBox6.Location = new System.Drawing.Point(150, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(126, 67);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hotkey";
            // 
            // lblSound2
            // 
            this.lblSound2.AutoSize = true;
            this.lblSound2.Location = new System.Drawing.Point(105, 45);
            this.lblSound2.Name = "lblSound2";
            this.lblSound2.Size = new System.Drawing.Size(16, 13);
            this.lblSound2.TabIndex = 9;
            this.lblSound2.Text = "♫";
            this.lblSound2.Click += new System.EventHandler(this.lblSound2_Click);
            // 
            // chkStart2
            // 
            this.chkStart2.AutoSize = true;
            this.chkStart2.Location = new System.Drawing.Point(6, 44);
            this.chkStart2.Name = "chkStart2";
            this.chkStart2.Size = new System.Drawing.Size(96, 17);
            this.chkStart2.TabIndex = 8;
            this.chkStart2.Text = "Start Auto Cast";
            this.chkStart2.UseVisualStyleBackColor = true;
            // 
            // chkHotKey2
            // 
            this.chkHotKey2.AutoSize = true;
            this.chkHotKey2.Location = new System.Drawing.Point(6, 20);
            this.chkHotKey2.Name = "chkHotKey2";
            this.chkHotKey2.Size = new System.Drawing.Size(15, 14);
            this.chkHotKey2.TabIndex = 7;
            this.chkHotKey2.UseVisualStyleBackColor = true;
            // 
            // boxHotKey2
            // 
            this.boxHotKey2.Location = new System.Drawing.Point(27, 17);
            this.boxHotKey2.Name = "boxHotKey2";
            this.boxHotKey2.ReadOnly = true;
            this.boxHotKey2.Size = new System.Drawing.Size(93, 21);
            this.boxHotKey2.TabIndex = 1;
            this.boxHotKey2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxHotKey2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delay:";
            this.label2.Click += new System.EventHandler(this.lblDelay2_Click);
            // 
            // boxDelay2
            // 
            this.boxDelay2.Location = new System.Drawing.Point(60, 122);
            this.boxDelay2.Name = "boxDelay2";
            this.boxDelay2.Size = new System.Drawing.Size(81, 21);
            this.boxDelay2.TabIndex = 5;
            this.boxDelay2.Text = "100";
            // 
            // btnStartMacro2
            // 
            this.btnStartMacro2.Location = new System.Drawing.Point(151, 122);
            this.btnStartMacro2.Name = "btnStartMacro2";
            this.btnStartMacro2.Size = new System.Drawing.Size(126, 23);
            this.btnStartMacro2.TabIndex = 4;
            this.btnStartMacro2.Text = "Start Auto Cast";
            this.btnStartMacro2.UseVisualStyleBackColor = true;
            this.btnStartMacro2.Click += new System.EventHandler(this.btnStartMacro2_Click);
            // 
            // btnClearMacro2
            // 
            this.btnClearMacro2.Location = new System.Drawing.Point(151, 93);
            this.btnClearMacro2.Name = "btnClearMacro2";
            this.btnClearMacro2.Size = new System.Drawing.Size(126, 23);
            this.btnClearMacro2.TabIndex = 3;
            this.btnClearMacro2.Text = "Clear Macro";
            this.btnClearMacro2.UseVisualStyleBackColor = true;
            this.btnClearMacro2.Click += new System.EventHandler(this.btnClearMacro2_Click);
            // 
            // boxMacro2
            // 
            this.boxMacro2.Location = new System.Drawing.Point(9, 20);
            this.boxMacro2.Multiline = true;
            this.boxMacro2.Name = "boxMacro2";
            this.boxMacro2.ReadOnly = true;
            this.boxMacro2.Size = new System.Drawing.Size(132, 96);
            this.boxMacro2.TabIndex = 0;
            this.boxMacro2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxMacro2_KeyDown);
            // 
            // back1
            // 
            this.back1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.back1_DoWork);
            // 
            // macro2
            // 
            this.macro2.Enabled = true;
            this.macro2.Tick += new System.EventHandler(this.macro2_Tick);
            // 
            // back2
            // 
            this.back2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.back2_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "v1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Macro 1.0(Alpha)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxWindowTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowWindow;
        private System.Windows.Forms.Button btnHideWindow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStartMacro1;
        private System.Windows.Forms.Button btnClearMacro1;
        private System.Windows.Forms.TextBox boxHotKey1;
        private System.Windows.Forms.TextBox boxMacro1;
        private System.Windows.Forms.Label lblDelay1;
        private System.Windows.Forms.TextBox boxDelay1;
        private System.Windows.Forms.Timer macro1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkStart1;
        private System.Windows.Forms.CheckBox chkHotKey1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkStart2;
        private System.Windows.Forms.CheckBox chkHotKey2;
        private System.Windows.Forms.TextBox boxHotKey2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxDelay2;
        private System.Windows.Forms.Button btnStartMacro2;
        private System.Windows.Forms.Button btnClearMacro2;
        private System.Windows.Forms.TextBox boxMacro2;
        private System.ComponentModel.BackgroundWorker back1;
        private System.Windows.Forms.Button btnLockOn;
        private System.Windows.Forms.Timer macro2;
        private System.ComponentModel.BackgroundWorker back2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSound1;
        private System.Windows.Forms.Label lblSound2;

    }
}

