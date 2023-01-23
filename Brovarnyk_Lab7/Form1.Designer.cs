namespace Brovarnyk_Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveFBtn = new System.Windows.Forms.Button();
            this.saveFPathBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outEntropyStLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFBtn = new System.Windows.Forms.Button();
            this.openFPathBox = new System.Windows.Forms.TextBox();
            this.inEntropyStLabel = new System.Windows.Forms.Label();
            this.sizeStLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.genVecCheckBox = new System.Windows.Forms.CheckBox();
            this.vectorTextBox = new System.Windows.Forms.TextBox();
            this.genVectorBtn = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.genKeyBtn = new System.Windows.Forms.Button();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.openSettingsBtn = new System.Windows.Forms.Button();
            this.keyLengthComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rc2RadioBtn = new System.Windows.Forms.RadioButton();
            this.trDESRadioBtn = new System.Windows.Forms.RadioButton();
            this.desRadioBtn = new System.Windows.Forms.RadioButton();
            this.rijndaelRadioBtn = new System.Windows.Forms.RadioButton();
            this.aesRadioBtn = new System.Windows.Forms.RadioButton();
            this.encodeBtn = new System.Windows.Forms.Button();
            this.decodeBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(652, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveFBtn);
            this.groupBox4.Controls.Add(this.saveFPathBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.outEntropyStLabel);
            this.groupBox4.Location = new System.Drawing.Point(6, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(616, 62);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // saveFBtn
            // 
            this.saveFBtn.Location = new System.Drawing.Point(568, 17);
            this.saveFBtn.Name = "saveFBtn";
            this.saveFBtn.Size = new System.Drawing.Size(42, 23);
            this.saveFBtn.TabIndex = 14;
            this.saveFBtn.Text = "...";
            this.toolTip1.SetToolTip(this.saveFBtn, "Choose output file");
            this.saveFBtn.UseVisualStyleBackColor = true;
            this.saveFBtn.Click += new System.EventHandler(this.saveFBtn_Click);
            // 
            // saveFPathBox
            // 
            this.saveFPathBox.Location = new System.Drawing.Point(9, 19);
            this.saveFPathBox.Name = "saveFPathBox";
            this.saveFPathBox.Size = new System.Drawing.Size(553, 20);
            this.saveFPathBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Entropy";
            // 
            // outEntropyStLabel
            // 
            this.outEntropyStLabel.AutoSize = true;
            this.outEntropyStLabel.Location = new System.Drawing.Point(50, 46);
            this.outEntropyStLabel.Name = "outEntropyStLabel";
            this.outEntropyStLabel.Size = new System.Drawing.Size(25, 13);
            this.outEntropyStLabel.TabIndex = 12;
            this.outEntropyStLabel.Text = "???";
            this.toolTip1.SetToolTip(this.outEntropyStLabel, "Copy entropy value to Clipboard");
            this.outEntropyStLabel.Click += new System.EventHandler(this.outEntropyStLabel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.openFBtn);
            this.groupBox3.Controls.Add(this.openFPathBox);
            this.groupBox3.Controls.Add(this.inEntropyStLabel);
            this.groupBox3.Controls.Add(this.sizeStLabel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 62);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // openFBtn
            // 
            this.openFBtn.Location = new System.Drawing.Point(568, 17);
            this.openFBtn.Name = "openFBtn";
            this.openFBtn.Size = new System.Drawing.Size(42, 23);
            this.openFBtn.TabIndex = 11;
            this.openFBtn.Text = "...";
            this.toolTip1.SetToolTip(this.openFBtn, "Choose input file");
            this.openFBtn.UseVisualStyleBackColor = true;
            this.openFBtn.Click += new System.EventHandler(this.openFBtn_Click);
            // 
            // openFPathBox
            // 
            this.openFPathBox.Location = new System.Drawing.Point(9, 19);
            this.openFPathBox.Name = "openFPathBox";
            this.openFPathBox.Size = new System.Drawing.Size(553, 20);
            this.openFPathBox.TabIndex = 11;
            // 
            // inEntropyStLabel
            // 
            this.inEntropyStLabel.AutoSize = true;
            this.inEntropyStLabel.Location = new System.Drawing.Point(50, 46);
            this.inEntropyStLabel.Name = "inEntropyStLabel";
            this.inEntropyStLabel.Size = new System.Drawing.Size(25, 13);
            this.inEntropyStLabel.TabIndex = 11;
            this.inEntropyStLabel.Text = "???";
            this.toolTip1.SetToolTip(this.inEntropyStLabel, "Copy entropy value to Clipboard");
            this.inEntropyStLabel.Click += new System.EventHandler(this.inEntropyStLabel_Click);
            // 
            // sizeStLabel
            // 
            this.sizeStLabel.AutoSize = true;
            this.sizeStLabel.Location = new System.Drawing.Point(386, 46);
            this.sizeStLabel.Name = "sizeStLabel";
            this.sizeStLabel.Size = new System.Drawing.Size(25, 13);
            this.sizeStLabel.TabIndex = 10;
            this.sizeStLabel.Text = "???";
            this.toolTip1.SetToolTip(this.sizeStLabel, "Input file size");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Entropy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.genVecCheckBox);
            this.groupBox2.Controls.Add(this.vectorTextBox);
            this.groupBox2.Controls.Add(this.genVectorBtn);
            this.groupBox2.Controls.Add(this.keyTextBox);
            this.groupBox2.Controls.Add(this.genKeyBtn);
            this.groupBox2.Controls.Add(this.saveSettingsBtn);
            this.groupBox2.Controls.Add(this.openSettingsBtn);
            this.groupBox2.Controls.Add(this.keyLengthComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 174);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // genVecCheckBox
            // 
            this.genVecCheckBox.AutoSize = true;
            this.genVecCheckBox.Checked = true;
            this.genVecCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.genVecCheckBox.Location = new System.Drawing.Point(392, 90);
            this.genVecCheckBox.Name = "genVecCheckBox";
            this.genVecCheckBox.Size = new System.Drawing.Size(54, 17);
            this.genVecCheckBox.TabIndex = 19;
            this.genVecCheckBox.Text = "BI = 0";
            this.toolTip1.SetToolTip(this.genVecCheckBox, "Init vector fill with zeros");
            this.genVecCheckBox.UseVisualStyleBackColor = true;
            this.genVecCheckBox.CheckedChanged += new System.EventHandler(this.genVecCheckBox_CheckedChanged);
            // 
            // vectorTextBox
            // 
            this.vectorTextBox.Enabled = false;
            this.vectorTextBox.Location = new System.Drawing.Point(15, 87);
            this.vectorTextBox.Name = "vectorTextBox";
            this.vectorTextBox.Size = new System.Drawing.Size(314, 20);
            this.vectorTextBox.TabIndex = 18;
            this.vectorTextBox.TextChanged += new System.EventHandler(this.vectorTextBox_TextChanged);
            this.vectorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vectorTextBox_KeyPress);
            // 
            // genVectorBtn
            // 
            this.genVectorBtn.BackgroundImage = global::Brovarnyk_Lab7.Properties.Resources.hello;
            this.genVectorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.genVectorBtn.Enabled = false;
            this.genVectorBtn.Location = new System.Drawing.Point(335, 83);
            this.genVectorBtn.Name = "genVectorBtn";
            this.genVectorBtn.Size = new System.Drawing.Size(51, 27);
            this.genVectorBtn.TabIndex = 17;
            this.toolTip1.SetToolTip(this.genVectorBtn, "Generate new init vector");
            this.genVectorBtn.UseVisualStyleBackColor = true;
            this.genVectorBtn.Click += new System.EventHandler(this.genVectorBtn_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(15, 46);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(314, 20);
            this.keyTextBox.TabIndex = 16;
            this.keyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            this.keyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyTextBox_KeyPress);
            // 
            // genKeyBtn
            // 
            this.genKeyBtn.BackgroundImage = global::Brovarnyk_Lab7.Properties.Resources.key1;
            this.genKeyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.genKeyBtn.Location = new System.Drawing.Point(335, 42);
            this.genKeyBtn.Name = "genKeyBtn";
            this.genKeyBtn.Size = new System.Drawing.Size(51, 27);
            this.genKeyBtn.TabIndex = 13;
            this.toolTip1.SetToolTip(this.genKeyBtn, "Generate new key");
            this.genKeyBtn.UseVisualStyleBackColor = true;
            this.genKeyBtn.Click += new System.EventHandler(this.genKeyBtn_Click);
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.BackgroundImage = global::Brovarnyk_Lab7.Properties.Resources.folder;
            this.saveSettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveSettingsBtn.Location = new System.Drawing.Point(508, 13);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(51, 40);
            this.saveSettingsBtn.TabIndex = 12;
            this.toolTip1.SetToolTip(this.saveSettingsBtn, "Save settings");
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // openSettingsBtn
            // 
            this.openSettingsBtn.BackgroundImage = global::Brovarnyk_Lab7.Properties.Resources.open_folder;
            this.openSettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openSettingsBtn.Location = new System.Drawing.Point(565, 13);
            this.openSettingsBtn.Name = "openSettingsBtn";
            this.openSettingsBtn.Size = new System.Drawing.Size(51, 40);
            this.openSettingsBtn.TabIndex = 11;
            this.toolTip1.SetToolTip(this.openSettingsBtn, "Restore settings");
            this.openSettingsBtn.UseVisualStyleBackColor = true;
            this.openSettingsBtn.Click += new System.EventHandler(this.openSettingsBtn_Click);
            // 
            // keyLengthComboBox
            // 
            this.keyLengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyLengthComboBox.FormattingEnabled = true;
            this.keyLengthComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.keyLengthComboBox.Location = new System.Drawing.Point(102, 13);
            this.keyLengthComboBox.Name = "keyLengthComboBox";
            this.keyLengthComboBox.Size = new System.Drawing.Size(60, 21);
            this.keyLengthComboBox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.keyLengthComboBox, "Change encoding Key Length");
            this.keyLengthComboBox.SelectedIndexChanged += new System.EventHandler(this.keyLengthComboBox_SelectedIndexChanged);
            this.keyLengthComboBox.TextChanged += new System.EventHandler(this.keyLengthComboBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key Length (bit):";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rc2RadioBtn);
            this.groupBox5.Controls.Add(this.trDESRadioBtn);
            this.groupBox5.Controls.Add(this.desRadioBtn);
            this.groupBox5.Controls.Add(this.rijndaelRadioBtn);
            this.groupBox5.Controls.Add(this.aesRadioBtn);
            this.groupBox5.Location = new System.Drawing.Point(6, 113);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(616, 55);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Encryption";
            // 
            // rc2RadioBtn
            // 
            this.rc2RadioBtn.AutoSize = true;
            this.rc2RadioBtn.Location = new System.Drawing.Point(262, 19);
            this.rc2RadioBtn.Name = "rc2RadioBtn";
            this.rc2RadioBtn.Size = new System.Drawing.Size(46, 17);
            this.rc2RadioBtn.TabIndex = 4;
            this.rc2RadioBtn.Text = "RC2";
            this.rc2RadioBtn.UseVisualStyleBackColor = true;
            this.rc2RadioBtn.CheckedChanged += new System.EventHandler(this.rc2RadioBtn_CheckedChanged);
            // 
            // trDESRadioBtn
            // 
            this.trDESRadioBtn.AutoSize = true;
            this.trDESRadioBtn.Location = new System.Drawing.Point(183, 19);
            this.trDESRadioBtn.Name = "trDESRadioBtn";
            this.trDESRadioBtn.Size = new System.Drawing.Size(73, 17);
            this.trDESRadioBtn.TabIndex = 3;
            this.trDESRadioBtn.Text = "TripleDES";
            this.trDESRadioBtn.UseVisualStyleBackColor = true;
            this.trDESRadioBtn.CheckedChanged += new System.EventHandler(this.trDESRadioBtn_CheckedChanged);
            // 
            // desRadioBtn
            // 
            this.desRadioBtn.AutoSize = true;
            this.desRadioBtn.Location = new System.Drawing.Point(130, 19);
            this.desRadioBtn.Name = "desRadioBtn";
            this.desRadioBtn.Size = new System.Drawing.Size(47, 17);
            this.desRadioBtn.TabIndex = 2;
            this.desRadioBtn.Text = "DES";
            this.desRadioBtn.UseVisualStyleBackColor = true;
            this.desRadioBtn.CheckedChanged += new System.EventHandler(this.desRadioBtn_CheckedChanged);
            // 
            // rijndaelRadioBtn
            // 
            this.rijndaelRadioBtn.AutoSize = true;
            this.rijndaelRadioBtn.Location = new System.Drawing.Point(61, 19);
            this.rijndaelRadioBtn.Name = "rijndaelRadioBtn";
            this.rijndaelRadioBtn.Size = new System.Drawing.Size(63, 17);
            this.rijndaelRadioBtn.TabIndex = 1;
            this.rijndaelRadioBtn.Text = "Rijndael";
            this.rijndaelRadioBtn.UseVisualStyleBackColor = true;
            this.rijndaelRadioBtn.CheckedChanged += new System.EventHandler(this.rijndaelRadioBtn_CheckedChanged);
            // 
            // aesRadioBtn
            // 
            this.aesRadioBtn.AutoSize = true;
            this.aesRadioBtn.Checked = true;
            this.aesRadioBtn.Location = new System.Drawing.Point(9, 20);
            this.aesRadioBtn.Name = "aesRadioBtn";
            this.aesRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.aesRadioBtn.TabIndex = 0;
            this.aesRadioBtn.TabStop = true;
            this.aesRadioBtn.Text = "AES";
            this.aesRadioBtn.UseVisualStyleBackColor = true;
            this.aesRadioBtn.CheckedChanged += new System.EventHandler(this.aesRadioBtn_CheckedChanged);
            // 
            // encodeBtn
            // 
            this.encodeBtn.Location = new System.Drawing.Point(18, 375);
            this.encodeBtn.Name = "encodeBtn";
            this.encodeBtn.Size = new System.Drawing.Size(75, 23);
            this.encodeBtn.TabIndex = 4;
            this.encodeBtn.Text = "Encode";
            this.toolTip1.SetToolTip(this.encodeBtn, "Start encoding");
            this.encodeBtn.UseVisualStyleBackColor = true;
            this.encodeBtn.Click += new System.EventHandler(this.encodeBtn_Click);
            // 
            // decodeBtn
            // 
            this.decodeBtn.Location = new System.Drawing.Point(99, 375);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(75, 23);
            this.decodeBtn.TabIndex = 5;
            this.decodeBtn.Text = "Decode";
            this.toolTip1.SetToolTip(this.decodeBtn, "Start decoding");
            this.decodeBtn.UseVisualStyleBackColor = true;
            this.decodeBtn.Click += new System.EventHandler(this.decodeBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(180, 375);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.toolTip1.SetToolTip(this.stopBtn, "Stop encoding/decoding");
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total time (hh : mm : ss.ms):";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(404, 380);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(70, 13);
            this.totalTimeLabel.TabIndex = 8;
            this.totalTimeLabel.Text = "00:00:00.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 410);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.encodeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button encodeBtn;
        private System.Windows.Forms.Button decodeBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label inEntropyStLabel;
        private System.Windows.Forms.Label sizeStLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outEntropyStLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox keyLengthComboBox;
        private System.Windows.Forms.Button saveFBtn;
        private System.Windows.Forms.TextBox saveFPathBox;
        private System.Windows.Forms.Button openFBtn;
        private System.Windows.Forms.TextBox openFPathBox;
        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.Button openSettingsBtn;
        private System.Windows.Forms.CheckBox genVecCheckBox;
        private System.Windows.Forms.TextBox vectorTextBox;
        private System.Windows.Forms.Button genVectorBtn;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button genKeyBtn;
        private System.Windows.Forms.RadioButton rc2RadioBtn;
        private System.Windows.Forms.RadioButton trDESRadioBtn;
        private System.Windows.Forms.RadioButton desRadioBtn;
        private System.Windows.Forms.RadioButton rijndaelRadioBtn;
        private System.Windows.Forms.RadioButton aesRadioBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

