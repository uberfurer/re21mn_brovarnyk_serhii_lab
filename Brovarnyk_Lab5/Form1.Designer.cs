namespace Brovarnyk_Lab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inFTextBox = new System.Windows.Forms.TextBox();
            this.outFTextBox = new System.Windows.Forms.TextBox();
            this.inFOpenBtn = new System.Windows.Forms.Button();
            this.outFSaveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sha512RadioBtn = new System.Windows.Forms.RadioButton();
            this.sha384RadioBtn = new System.Windows.Forms.RadioButton();
            this.sha256RadioBtn = new System.Windows.Forms.RadioButton();
            this.sha1RadioBtn = new System.Windows.Forms.RadioButton();
            this.md5RadioBtn = new System.Windows.Forms.RadioButton();
            this.ripeRadioBtn = new System.Windows.Forms.RadioButton();
            this.hashRadioBtn = new System.Windows.Forms.RadioButton();
            this.crcRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inFSizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.outFSizeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.executeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.authorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.descriptionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // inFTextBox
            // 
            this.inFTextBox.Location = new System.Drawing.Point(52, 12);
            this.inFTextBox.Name = "inFTextBox";
            this.inFTextBox.Size = new System.Drawing.Size(214, 20);
            this.inFTextBox.TabIndex = 2;
            // 
            // outFTextBox
            // 
            this.outFTextBox.Location = new System.Drawing.Point(52, 40);
            this.outFTextBox.Name = "outFTextBox";
            this.outFTextBox.Size = new System.Drawing.Size(214, 20);
            this.outFTextBox.TabIndex = 3;
            // 
            // inFOpenBtn
            // 
            this.inFOpenBtn.Location = new System.Drawing.Point(271, 10);
            this.inFOpenBtn.Name = "inFOpenBtn";
            this.inFOpenBtn.Size = new System.Drawing.Size(47, 23);
            this.inFOpenBtn.TabIndex = 4;
            this.inFOpenBtn.Text = "...";
            this.inFOpenBtn.UseVisualStyleBackColor = true;
            this.inFOpenBtn.Click += new System.EventHandler(this.inFOpenBtn_Click);
            // 
            // outFSaveBtn
            // 
            this.outFSaveBtn.Location = new System.Drawing.Point(271, 39);
            this.outFSaveBtn.Name = "outFSaveBtn";
            this.outFSaveBtn.Size = new System.Drawing.Size(47, 23);
            this.outFSaveBtn.TabIndex = 5;
            this.outFSaveBtn.Text = "...";
            this.outFSaveBtn.UseVisualStyleBackColor = true;
            this.outFSaveBtn.Click += new System.EventHandler(this.outFSaveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sha512RadioBtn);
            this.groupBox1.Controls.Add(this.sha384RadioBtn);
            this.groupBox1.Controls.Add(this.sha256RadioBtn);
            this.groupBox1.Controls.Add(this.sha1RadioBtn);
            this.groupBox1.Controls.Add(this.md5RadioBtn);
            this.groupBox1.Controls.Add(this.ripeRadioBtn);
            this.groupBox1.Controls.Add(this.hashRadioBtn);
            this.groupBox1.Controls.Add(this.crcRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(10, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // sha512RadioBtn
            // 
            this.sha512RadioBtn.AutoSize = true;
            this.sha512RadioBtn.Location = new System.Drawing.Point(98, 88);
            this.sha512RadioBtn.Name = "sha512RadioBtn";
            this.sha512RadioBtn.Size = new System.Drawing.Size(68, 17);
            this.sha512RadioBtn.TabIndex = 14;
            this.sha512RadioBtn.TabStop = true;
            this.sha512RadioBtn.Text = "SHA-512";
            this.sha512RadioBtn.UseVisualStyleBackColor = true;
            // 
            // sha384RadioBtn
            // 
            this.sha384RadioBtn.AutoSize = true;
            this.sha384RadioBtn.Location = new System.Drawing.Point(98, 65);
            this.sha384RadioBtn.Name = "sha384RadioBtn";
            this.sha384RadioBtn.Size = new System.Drawing.Size(68, 17);
            this.sha384RadioBtn.TabIndex = 13;
            this.sha384RadioBtn.TabStop = true;
            this.sha384RadioBtn.Text = "SHA-384";
            this.sha384RadioBtn.UseVisualStyleBackColor = true;
            // 
            // sha256RadioBtn
            // 
            this.sha256RadioBtn.AutoSize = true;
            this.sha256RadioBtn.Location = new System.Drawing.Point(98, 42);
            this.sha256RadioBtn.Name = "sha256RadioBtn";
            this.sha256RadioBtn.Size = new System.Drawing.Size(68, 17);
            this.sha256RadioBtn.TabIndex = 12;
            this.sha256RadioBtn.TabStop = true;
            this.sha256RadioBtn.Text = "SHA-256";
            this.sha256RadioBtn.UseVisualStyleBackColor = true;
            // 
            // sha1RadioBtn
            // 
            this.sha1RadioBtn.AutoSize = true;
            this.sha1RadioBtn.Location = new System.Drawing.Point(98, 19);
            this.sha1RadioBtn.Name = "sha1RadioBtn";
            this.sha1RadioBtn.Size = new System.Drawing.Size(56, 17);
            this.sha1RadioBtn.TabIndex = 11;
            this.sha1RadioBtn.TabStop = true;
            this.sha1RadioBtn.Text = "SHA-1";
            this.sha1RadioBtn.UseVisualStyleBackColor = true;
            // 
            // md5RadioBtn
            // 
            this.md5RadioBtn.AutoSize = true;
            this.md5RadioBtn.Location = new System.Drawing.Point(8, 88);
            this.md5RadioBtn.Name = "md5RadioBtn";
            this.md5RadioBtn.Size = new System.Drawing.Size(48, 17);
            this.md5RadioBtn.TabIndex = 10;
            this.md5RadioBtn.TabStop = true;
            this.md5RadioBtn.Text = "MD5";
            this.md5RadioBtn.UseVisualStyleBackColor = true;
            // 
            // ripeRadioBtn
            // 
            this.ripeRadioBtn.AutoSize = true;
            this.ripeRadioBtn.Location = new System.Drawing.Point(8, 65);
            this.ripeRadioBtn.Name = "ripeRadioBtn";
            this.ripeRadioBtn.Size = new System.Drawing.Size(85, 17);
            this.ripeRadioBtn.TabIndex = 9;
            this.ripeRadioBtn.TabStop = true;
            this.ripeRadioBtn.Text = "RIPEMD160";
            this.ripeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // hashRadioBtn
            // 
            this.hashRadioBtn.AutoSize = true;
            this.hashRadioBtn.Location = new System.Drawing.Point(8, 42);
            this.hashRadioBtn.Name = "hashRadioBtn";
            this.hashRadioBtn.Size = new System.Drawing.Size(93, 17);
            this.hashRadioBtn.TabIndex = 8;
            this.hashRadioBtn.TabStop = true;
            this.hashRadioBtn.Text = "HashAlgorithm";
            this.hashRadioBtn.UseVisualStyleBackColor = true;
            // 
            // crcRadioBtn
            // 
            this.crcRadioBtn.AutoSize = true;
            this.crcRadioBtn.Location = new System.Drawing.Point(8, 19);
            this.crcRadioBtn.Name = "crcRadioBtn";
            this.crcRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.crcRadioBtn.TabIndex = 7;
            this.crcRadioBtn.TabStop = true;
            this.crcRadioBtn.Text = "CRC32";
            this.crcRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inFSizeLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(193, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 51);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size (Mbyte)";
            // 
            // inFSizeLabel
            // 
            this.inFSizeLabel.AutoSize = true;
            this.inFSizeLabel.Location = new System.Drawing.Point(61, 26);
            this.inFSizeLabel.Name = "inFSizeLabel";
            this.inFSizeLabel.Size = new System.Drawing.Size(25, 13);
            this.inFSizeLabel.TabIndex = 12;
            this.inFSizeLabel.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Input File:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.outFSizeLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(193, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 51);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size (byte)";
            // 
            // outFSizeLabel
            // 
            this.outFSizeLabel.AutoSize = true;
            this.outFSizeLabel.Location = new System.Drawing.Point(70, 24);
            this.outFSizeLabel.Name = "outFSizeLabel";
            this.outFSizeLabel.Size = new System.Drawing.Size(25, 13);
            this.outFSizeLabel.TabIndex = 11;
            this.outFSizeLabel.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output File:";
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(18, 227);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(59, 23);
            this.executeBtn.TabIndex = 9;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(83, 227);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(58, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // authorLinkLabel
            // 
            this.authorLinkLabel.AutoSize = true;
            this.authorLinkLabel.Location = new System.Drawing.Point(163, 232);
            this.authorLinkLabel.Name = "authorLinkLabel";
            this.authorLinkLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLinkLabel.TabIndex = 12;
            this.authorLinkLabel.TabStop = true;
            this.authorLinkLabel.Text = "Author";
            this.authorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorLinkLabel_LinkClicked);
            // 
            // descriptionLinkLabel
            // 
            this.descriptionLinkLabel.AutoSize = true;
            this.descriptionLinkLabel.Location = new System.Drawing.Point(211, 232);
            this.descriptionLinkLabel.Name = "descriptionLinkLabel";
            this.descriptionLinkLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLinkLabel.TabIndex = 13;
            this.descriptionLinkLabel.TabStop = true;
            this.descriptionLinkLabel.Text = "Description";
            this.descriptionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.descriptionLinkLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total time (dd : hh : mm : ss: ms):";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(192, 198);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(79, 13);
            this.totalTimeLabel.TabIndex = 15;
            this.totalTimeLabel.Text = "0:00:00:00.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionLinkLabel);
            this.Controls.Add(this.authorLinkLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outFSaveBtn);
            this.Controls.Add(this.inFOpenBtn);
            this.Controls.Add(this.outFTextBox);
            this.Controls.Add(this.inFTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CRC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inFTextBox;
        private System.Windows.Forms.TextBox outFTextBox;
        private System.Windows.Forms.Button inFOpenBtn;
        private System.Windows.Forms.Button outFSaveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton md5RadioBtn;
        private System.Windows.Forms.RadioButton ripeRadioBtn;
        private System.Windows.Forms.RadioButton hashRadioBtn;
        private System.Windows.Forms.RadioButton crcRadioBtn;
        private System.Windows.Forms.RadioButton sha512RadioBtn;
        private System.Windows.Forms.RadioButton sha384RadioBtn;
        private System.Windows.Forms.RadioButton sha256RadioBtn;
        private System.Windows.Forms.RadioButton sha1RadioBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label inFSizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outFSizeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.LinkLabel authorLinkLabel;
        private System.Windows.Forms.LinkLabel descriptionLinkLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalTimeLabel;
    }
}

