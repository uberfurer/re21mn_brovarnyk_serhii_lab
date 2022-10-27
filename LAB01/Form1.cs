using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text == "admin" && passwordTextBox.Text == "qwerty")
            {
                MessageBox.Show("You`re successfully logged in!");
                loginSigLabel.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Incorrect login or password!\n\tTry again!");
                loginSigLabel.BackColor = Color.Red;
            }
        }
    }
}
