namespace Brovarnyk_Lab4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.openFPathBox = new System.Windows.Forms.TextBox();
            this.saveFPathBox = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.keyPathBox = new System.Windows.Forms.TextBox();
            this.openKeyBtn = new System.Windows.Forms.Button();
            this.saveKeyBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.genBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.totTTextLabel = new System.Windows.Forms.Label();
            this.totTimeLabel = new System.Windows.Forms.Label();
            this.kSizeTextLabel = new System.Windows.Forms.Label();
            this.keySizeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveFileBtn);
            this.groupBox1.Controls.Add(this.openFileBtn);
            this.groupBox1.Controls.Add(this.saveFPathBox);
            this.groupBox1.Controls.Add(this.openFPathBox);
            this.groupBox1.Controls.Add(this.saveLabel);
            this.groupBox1.Controls.Add(this.openLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.keySizeLabel);
            this.groupBox2.Controls.Add(this.kSizeTextLabel);
            this.groupBox2.Controls.Add(this.genBtn);
            this.groupBox2.Controls.Add(this.saveKeyBtn);
            this.groupBox2.Controls.Add(this.openKeyBtn);
            this.groupBox2.Controls.Add(this.keyPathBox);
            this.groupBox2.Controls.Add(this.keyLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(6, 27);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(33, 13);
            this.openLabel.TabIndex = 0;
            this.openLabel.Text = "Open";
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(6, 60);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(44, 13);
            this.saveLabel.TabIndex = 1;
            this.saveLabel.Text = "Save to";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(14, 31);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 2;
            this.keyLabel.Text = "Key";
            // 
            // openFPathBox
            // 
            this.openFPathBox.Location = new System.Drawing.Point(56, 24);
            this.openFPathBox.Name = "openFPathBox";
            this.openFPathBox.Size = new System.Drawing.Size(262, 20);
            this.openFPathBox.TabIndex = 2;
            // 
            // saveFPathBox
            // 
            this.saveFPathBox.Location = new System.Drawing.Point(56, 57);
            this.saveFPathBox.Name = "saveFPathBox";
            this.saveFPathBox.Size = new System.Drawing.Size(262, 20);
            this.saveFPathBox.TabIndex = 3;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(324, 22);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(48, 23);
            this.openFileBtn.TabIndex = 4;
            this.openFileBtn.Text = "...";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(324, 55);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(48, 23);
            this.saveFileBtn.TabIndex = 5;
            this.saveFileBtn.Text = "...";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // keyPathBox
            // 
            this.keyPathBox.Location = new System.Drawing.Point(56, 28);
            this.keyPathBox.Name = "keyPathBox";
            this.keyPathBox.Size = new System.Drawing.Size(208, 20);
            this.keyPathBox.TabIndex = 3;
            // 
            // openKeyBtn
            // 
            this.openKeyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openKeyBtn.BackgroundImage")));
            this.openKeyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openKeyBtn.Location = new System.Drawing.Point(324, 26);
            this.openKeyBtn.Name = "openKeyBtn";
            this.openKeyBtn.Size = new System.Drawing.Size(48, 46);
            this.openKeyBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.openKeyBtn, "Open key file.");
            this.openKeyBtn.UseVisualStyleBackColor = true;
            this.openKeyBtn.Click += new System.EventHandler(this.openKeyBtn_Click);
            // 
            // saveKeyBtn
            // 
            this.saveKeyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveKeyBtn.BackgroundImage")));
            this.saveKeyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveKeyBtn.Location = new System.Drawing.Point(270, 27);
            this.saveKeyBtn.Name = "saveKeyBtn";
            this.saveKeyBtn.Size = new System.Drawing.Size(48, 44);
            this.saveKeyBtn.TabIndex = 6;
            this.toolTip1.SetToolTip(this.saveKeyBtn, "Save key to file.");
            this.saveKeyBtn.UseVisualStyleBackColor = true;
            this.saveKeyBtn.Click += new System.EventHandler(this.saveKeyBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(314, 210);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(70, 23);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // genBtn
            // 
            this.genBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("genBtn.BackgroundImage")));
            this.genBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.genBtn.Location = new System.Drawing.Point(144, 52);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(67, 31);
            this.genBtn.TabIndex = 7;
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // totTTextLabel
            // 
            this.totTTextLabel.AutoSize = true;
            this.totTTextLabel.Location = new System.Drawing.Point(18, 215);
            this.totTTextLabel.Name = "totTTextLabel";
            this.totTTextLabel.Size = new System.Drawing.Size(156, 13);
            this.totTTextLabel.TabIndex = 8;
            this.totTTextLabel.Text = "Total encoding time (m : s . ms):";
            // 
            // totTimeLabel
            // 
            this.totTimeLabel.AutoSize = true;
            this.totTimeLabel.Location = new System.Drawing.Point(180, 215);
            this.totTimeLabel.Name = "totTimeLabel";
            this.totTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.totTimeLabel.TabIndex = 9;
            this.totTimeLabel.Text = "00:00.000";
            // 
            // kSizeTextLabel
            // 
            this.kSizeTextLabel.AutoSize = true;
            this.kSizeTextLabel.Location = new System.Drawing.Point(6, 52);
            this.kSizeTextLabel.Name = "kSizeTextLabel";
            this.kSizeTextLabel.Size = new System.Drawing.Size(49, 13);
            this.kSizeTextLabel.TabIndex = 9;
            this.kSizeTextLabel.Text = "Key size:";
            // 
            // keySizeLabel
            // 
            this.keySizeLabel.AutoSize = true;
            this.keySizeLabel.Location = new System.Drawing.Point(14, 70);
            this.keySizeLabel.Name = "keySizeLabel";
            this.keySizeLabel.Size = new System.Drawing.Size(22, 13);
            this.keySizeLabel.TabIndex = 10;
            this.keySizeLabel.Text = "0 b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 243);
            this.Controls.Add(this.totTimeLabel);
            this.Controls.Add(this.totTTextLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XOR File";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox saveFPathBox;
        private System.Windows.Forms.TextBox openFPathBox;
        private System.Windows.Forms.Button saveKeyBtn;
        private System.Windows.Forms.Button openKeyBtn;
        private System.Windows.Forms.TextBox keyPathBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label totTTextLabel;
        private System.Windows.Forms.Label totTimeLabel;
        private System.Windows.Forms.Label keySizeLabel;
        private System.Windows.Forms.Label kSizeTextLabel;
    }
}

