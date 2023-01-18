namespace Brovarnyk_Lab2
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
            this.pLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.pETextBox = new System.Windows.Forms.TextBox();
            this.keyETextBox = new System.Windows.Forms.TextBox();
            this.cETextBox = new System.Windows.Forms.TextBox();
            this.xorButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.strFormatLabel = new System.Windows.Forms.Label();
            this.pDTextBox = new System.Windows.Forms.TextBox();
            this.keyDTextBox = new System.Windows.Forms.TextBox();
            this.cDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encoderLabel = new System.Windows.Forms.Label();
            this.decoderLabel = new System.Windows.Forms.Label();
            this.p2Label = new System.Windows.Forms.Label();
            this.p10Label = new System.Windows.Forms.Label();
            this.p16Label = new System.Windows.Forms.Label();
            this.key16Label = new System.Windows.Forms.Label();
            this.key10Label = new System.Windows.Forms.Label();
            this.key2Label = new System.Windows.Forms.Label();
            this.c16Label = new System.Windows.Forms.Label();
            this.c10Label = new System.Windows.Forms.Label();
            this.c2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(14, 49);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(23, 13);
            this.pLabel.TabIndex = 0;
            this.pLabel.Text = "P =";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(13, 75);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(34, 13);
            this.keyLabel.TabIndex = 1;
            this.keyLabel.Text = "Key =";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(14, 100);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(23, 13);
            this.cLabel.TabIndex = 2;
            this.cLabel.Text = "C =";
            // 
            // pETextBox
            // 
            this.pETextBox.Location = new System.Drawing.Point(54, 46);
            this.pETextBox.Name = "pETextBox";
            this.pETextBox.Size = new System.Drawing.Size(100, 20);
            this.pETextBox.TabIndex = 3;
            this.pETextBox.TextChanged += new System.EventHandler(this.pETextBox_TextChanged);
            this.pETextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pETextBox_KeyPress);
            // 
            // keyETextBox
            // 
            this.keyETextBox.Location = new System.Drawing.Point(54, 72);
            this.keyETextBox.Name = "keyETextBox";
            this.keyETextBox.Size = new System.Drawing.Size(100, 20);
            this.keyETextBox.TabIndex = 4;
            this.keyETextBox.TextChanged += new System.EventHandler(this.keyETextBox_TextChanged);
            this.keyETextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyETextBox_KeyPress);
            // 
            // cETextBox
            // 
            this.cETextBox.Location = new System.Drawing.Point(54, 97);
            this.cETextBox.Name = "cETextBox";
            this.cETextBox.ReadOnly = true;
            this.cETextBox.Size = new System.Drawing.Size(100, 20);
            this.cETextBox.TabIndex = 5;
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(160, 46);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(75, 26);
            this.xorButton.TabIndex = 6;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.xorButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(160, 93);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 24);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // strFormatLabel
            // 
            this.strFormatLabel.AutoSize = true;
            this.strFormatLabel.Location = new System.Drawing.Point(14, 9);
            this.strFormatLabel.Name = "strFormatLabel";
            this.strFormatLabel.Size = new System.Drawing.Size(299, 13);
            this.strFormatLabel.TabIndex = 8;
            this.strFormatLabel.Text = "You should use the following symbols for HEX values: 0-9, A-F";
            // 
            // pDTextBox
            // 
            this.pDTextBox.Location = new System.Drawing.Point(241, 97);
            this.pDTextBox.Name = "pDTextBox";
            this.pDTextBox.ReadOnly = true;
            this.pDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pDTextBox.TabIndex = 14;
            // 
            // keyDTextBox
            // 
            this.keyDTextBox.Location = new System.Drawing.Point(241, 72);
            this.keyDTextBox.Name = "keyDTextBox";
            this.keyDTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyDTextBox.TabIndex = 13;
            this.keyDTextBox.TextChanged += new System.EventHandler(this.keyDTextBox_TextChanged);
            this.keyDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyDTextBox_KeyPress);
            // 
            // cDTextBox
            // 
            this.cDTextBox.Location = new System.Drawing.Point(241, 46);
            this.cDTextBox.Name = "cDTextBox";
            this.cDTextBox.Size = new System.Drawing.Size(100, 20);
            this.cDTextBox.TabIndex = 12;
            this.cDTextBox.TextChanged += new System.EventHandler(this.cDTextBox_TextChanged);
            this.cDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cDTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "= P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "= Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "= C";
            // 
            // encoderLabel
            // 
            this.encoderLabel.AutoSize = true;
            this.encoderLabel.Location = new System.Drawing.Point(68, 30);
            this.encoderLabel.Name = "encoderLabel";
            this.encoderLabel.Size = new System.Drawing.Size(70, 13);
            this.encoderLabel.TabIndex = 15;
            this.encoderLabel.Text = "Encode XOR";
            // 
            // decoderLabel
            // 
            this.decoderLabel.AutoSize = true;
            this.decoderLabel.Location = new System.Drawing.Point(258, 30);
            this.decoderLabel.Name = "decoderLabel";
            this.decoderLabel.Size = new System.Drawing.Size(71, 13);
            this.decoderLabel.TabIndex = 16;
            this.decoderLabel.Text = "Decode XOR";
            // 
            // p2Label
            // 
            this.p2Label.AutoSize = true;
            this.p2Label.Location = new System.Drawing.Point(18, 129);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(29, 13);
            this.p2Label.TabIndex = 17;
            this.p2Label.Text = "P 2: ";
            // 
            // p10Label
            // 
            this.p10Label.AutoSize = true;
            this.p10Label.Location = new System.Drawing.Point(18, 151);
            this.p10Label.Name = "p10Label";
            this.p10Label.Size = new System.Drawing.Size(35, 13);
            this.p10Label.TabIndex = 18;
            this.p10Label.Text = "P 10: ";
            // 
            // p16Label
            // 
            this.p16Label.AutoSize = true;
            this.p16Label.Location = new System.Drawing.Point(18, 174);
            this.p16Label.Name = "p16Label";
            this.p16Label.Size = new System.Drawing.Size(32, 13);
            this.p16Label.TabIndex = 19;
            this.p16Label.Text = "P 16:";
            // 
            // key16Label
            // 
            this.key16Label.AutoSize = true;
            this.key16Label.Location = new System.Drawing.Point(133, 174);
            this.key16Label.Name = "key16Label";
            this.key16Label.Size = new System.Drawing.Size(43, 13);
            this.key16Label.TabIndex = 22;
            this.key16Label.Text = "Key 16:";
            // 
            // key10Label
            // 
            this.key10Label.AutoSize = true;
            this.key10Label.Location = new System.Drawing.Point(133, 151);
            this.key10Label.Name = "key10Label";
            this.key10Label.Size = new System.Drawing.Size(46, 13);
            this.key10Label.TabIndex = 21;
            this.key10Label.Text = "Key 10: ";
            // 
            // key2Label
            // 
            this.key2Label.AutoSize = true;
            this.key2Label.Location = new System.Drawing.Point(133, 129);
            this.key2Label.Name = "key2Label";
            this.key2Label.Size = new System.Drawing.Size(40, 13);
            this.key2Label.TabIndex = 20;
            this.key2Label.Text = "Key 2: ";
            // 
            // c16Label
            // 
            this.c16Label.AutoSize = true;
            this.c16Label.Location = new System.Drawing.Point(249, 174);
            this.c16Label.Name = "c16Label";
            this.c16Label.Size = new System.Drawing.Size(32, 13);
            this.c16Label.TabIndex = 25;
            this.c16Label.Text = "C 16:";
            // 
            // c10Label
            // 
            this.c10Label.AutoSize = true;
            this.c10Label.Location = new System.Drawing.Point(249, 151);
            this.c10Label.Name = "c10Label";
            this.c10Label.Size = new System.Drawing.Size(35, 13);
            this.c10Label.TabIndex = 24;
            this.c10Label.Text = "C 10: ";
            // 
            // c2Label
            // 
            this.c2Label.AutoSize = true;
            this.c2Label.Location = new System.Drawing.Point(249, 129);
            this.c2Label.Name = "c2Label";
            this.c2Label.Size = new System.Drawing.Size(29, 13);
            this.c2Label.TabIndex = 23;
            this.c2Label.Text = "C 2: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 203);
            this.Controls.Add(this.c16Label);
            this.Controls.Add(this.c10Label);
            this.Controls.Add(this.c2Label);
            this.Controls.Add(this.key16Label);
            this.Controls.Add(this.key10Label);
            this.Controls.Add(this.key2Label);
            this.Controls.Add(this.p16Label);
            this.Controls.Add(this.p10Label);
            this.Controls.Add(this.p2Label);
            this.Controls.Add(this.decoderLabel);
            this.Controls.Add(this.encoderLabel);
            this.Controls.Add(this.pDTextBox);
            this.Controls.Add(this.keyDTextBox);
            this.Controls.Add(this.cDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.strFormatLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.cETextBox);
            this.Controls.Add(this.keyETextBox);
            this.Controls.Add(this.pETextBox);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.pLabel);
            this.Name = "Form1";
            this.Text = "XOR Encoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.TextBox pETextBox;
        private System.Windows.Forms.TextBox keyETextBox;
        private System.Windows.Forms.TextBox cETextBox;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label strFormatLabel;
        private System.Windows.Forms.TextBox pDTextBox;
        private System.Windows.Forms.TextBox keyDTextBox;
        private System.Windows.Forms.TextBox cDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label encoderLabel;
        private System.Windows.Forms.Label decoderLabel;
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.Label p10Label;
        private System.Windows.Forms.Label p16Label;
        private System.Windows.Forms.Label key16Label;
        private System.Windows.Forms.Label key10Label;
        private System.Windows.Forms.Label key2Label;
        private System.Windows.Forms.Label c16Label;
        private System.Windows.Forms.Label c10Label;
        private System.Windows.Forms.Label c2Label;
    }
}

