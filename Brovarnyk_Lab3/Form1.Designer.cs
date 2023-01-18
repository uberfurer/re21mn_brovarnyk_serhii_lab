namespace Brovarnyk_Lab3
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
            this.pDTextBox = new System.Windows.Forms.TextBox();
            this.keyDTextBox = new System.Windows.Forms.TextBox();
            this.cDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.xorButton = new System.Windows.Forms.Button();
            this.cETextBox = new System.Windows.Forms.TextBox();
            this.keyETextBox = new System.Windows.Forms.TextBox();
            this.pETextBox = new System.Windows.Forms.TextBox();
            this.cLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.encGroupBox = new System.Windows.Forms.GroupBox();
            this.decGroupBox = new System.Windows.Forms.GroupBox();
            this.toolTipHEX = new System.Windows.Forms.ToolTip(this.components);
            this.encGroupBox.SuspendLayout();
            this.decGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDTextBox
            // 
            this.pDTextBox.Location = new System.Drawing.Point(32, 17);
            this.pDTextBox.Name = "pDTextBox";
            this.pDTextBox.ReadOnly = true;
            this.pDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pDTextBox.TabIndex = 40;
            // 
            // keyDTextBox
            // 
            this.keyDTextBox.Location = new System.Drawing.Point(32, 43);
            this.keyDTextBox.Name = "keyDTextBox";
            this.keyDTextBox.ReadOnly = true;
            this.keyDTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyDTextBox.TabIndex = 39;
            // 
            // cDTextBox
            // 
            this.cDTextBox.Location = new System.Drawing.Point(32, 68);
            this.cDTextBox.Name = "cDTextBox";
            this.cDTextBox.ReadOnly = true;
            this.cDTextBox.Size = new System.Drawing.Size(100, 20);
            this.cDTextBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "= P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "= Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "= C";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(225, 69);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 41);
            this.removeButton.TabIndex = 33;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(225, 22);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(75, 41);
            this.xorButton.TabIndex = 32;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.xorButton_Click);
            // 
            // cETextBox
            // 
            this.cETextBox.Location = new System.Drawing.Point(63, 70);
            this.cETextBox.Name = "cETextBox";
            this.cETextBox.ReadOnly = true;
            this.cETextBox.Size = new System.Drawing.Size(100, 20);
            this.cETextBox.TabIndex = 31;
            // 
            // keyETextBox
            // 
            this.keyETextBox.Location = new System.Drawing.Point(63, 45);
            this.keyETextBox.Name = "keyETextBox";
            this.keyETextBox.Size = new System.Drawing.Size(100, 20);
            this.keyETextBox.TabIndex = 30;
            // 
            // pETextBox
            // 
            this.pETextBox.Location = new System.Drawing.Point(63, 19);
            this.pETextBox.Name = "pETextBox";
            this.pETextBox.Size = new System.Drawing.Size(100, 20);
            this.pETextBox.TabIndex = 29;
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(23, 73);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(23, 13);
            this.cLabel.TabIndex = 28;
            this.cLabel.Text = "C =";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(22, 48);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(34, 13);
            this.keyLabel.TabIndex = 27;
            this.keyLabel.Text = "Key =";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(23, 22);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(23, 13);
            this.pLabel.TabIndex = 26;
            this.pLabel.Text = "P =";
            // 
            // encGroupBox
            // 
            this.encGroupBox.Controls.Add(this.pETextBox);
            this.encGroupBox.Controls.Add(this.pLabel);
            this.encGroupBox.Controls.Add(this.keyLabel);
            this.encGroupBox.Controls.Add(this.cLabel);
            this.encGroupBox.Controls.Add(this.keyETextBox);
            this.encGroupBox.Controls.Add(this.cETextBox);
            this.encGroupBox.Location = new System.Drawing.Point(19, 12);
            this.encGroupBox.Name = "encGroupBox";
            this.encGroupBox.Size = new System.Drawing.Size(200, 100);
            this.encGroupBox.TabIndex = 52;
            this.encGroupBox.TabStop = false;
            this.encGroupBox.Text = "Encoding";
            // 
            // decGroupBox
            // 
            this.decGroupBox.Controls.Add(this.cDTextBox);
            this.decGroupBox.Controls.Add(this.label3);
            this.decGroupBox.Controls.Add(this.label2);
            this.decGroupBox.Controls.Add(this.label1);
            this.decGroupBox.Controls.Add(this.keyDTextBox);
            this.decGroupBox.Controls.Add(this.pDTextBox);
            this.decGroupBox.Location = new System.Drawing.Point(306, 14);
            this.decGroupBox.Name = "decGroupBox";
            this.decGroupBox.Size = new System.Drawing.Size(200, 98);
            this.decGroupBox.TabIndex = 53;
            this.decGroupBox.TabStop = false;
            this.decGroupBox.Text = "Decoding";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 129);
            this.Controls.Add(this.decGroupBox);
            this.Controls.Add(this.encGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.xorButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.encGroupBox.ResumeLayout(false);
            this.encGroupBox.PerformLayout();
            this.decGroupBox.ResumeLayout(false);
            this.decGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox pDTextBox;
        private System.Windows.Forms.TextBox keyDTextBox;
        private System.Windows.Forms.TextBox cDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.TextBox cETextBox;
        private System.Windows.Forms.TextBox keyETextBox;
        private System.Windows.Forms.TextBox pETextBox;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.GroupBox encGroupBox;
        private System.Windows.Forms.GroupBox decGroupBox;
        private System.Windows.Forms.ToolTip toolTipHEX;
    }
}

