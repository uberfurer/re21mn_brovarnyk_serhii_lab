namespace LAB01
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.credentialsGB = new System.Windows.Forms.GroupBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginSigLabel = new System.Windows.Forms.Label();
            this.credentialsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // credentialsGB
            // 
            this.credentialsGB.Controls.Add(this.passwordLabel);
            this.credentialsGB.Controls.Add(this.loginLabel);
            this.credentialsGB.Controls.Add(this.passwordTextBox);
            this.credentialsGB.Controls.Add(this.loginTextBox);
            this.credentialsGB.Location = new System.Drawing.Point(12, 12);
            this.credentialsGB.Name = "credentialsGB";
            this.credentialsGB.Size = new System.Drawing.Size(233, 80);
            this.credentialsGB.TabIndex = 0;
            this.credentialsGB.TabStop = false;
            this.credentialsGB.Text = "Authorization";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(65, 19);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(152, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(65, 46);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(152, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(10, 22);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 49);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(89, 98);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginSigLabel
            // 
            this.loginSigLabel.AutoSize = true;
            this.loginSigLabel.BackColor = System.Drawing.Color.Red;
            this.loginSigLabel.Location = new System.Drawing.Point(170, 103);
            this.loginSigLabel.Name = "loginSigLabel";
            this.loginSigLabel.Size = new System.Drawing.Size(13, 13);
            this.loginSigLabel.TabIndex = 2;
            this.loginSigLabel.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 132);
            this.Controls.Add(this.loginSigLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.credentialsGB);
            this.Name = "Form1";
            this.Text = "Authorization Form";
            this.credentialsGB.ResumeLayout(false);
            this.credentialsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox credentialsGB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label loginSigLabel;
    }
}

