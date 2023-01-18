using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brovarnyk_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xorButton_Click(object sender, EventArgs e)
        {
            if (pETextBox.Text != "" && keyETextBox.Text != "" || cDTextBox.Text != "" && keyDTextBox.Text != "")
            {
                if(!pETextBox.ReadOnly)
                {
                    try
                    {
                        int p = Convert.ToInt32(pETextBox.Text, 16);
                        int key = Convert.ToInt32(keyETextBox.Text, 16);
                        int c = p ^ key;
                        cETextBox.Text = Convert.ToString(c, 16).ToUpper();
                        FillValues(p, key, c);
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("This value is too big! Try again with a smaller one");
                    }
                }
                else
                {
                    try
                    {
                        int c = Convert.ToInt32(cDTextBox.Text, 16);
                        int key = Convert.ToInt32(keyDTextBox.Text, 16);
                        int p = c ^ key;
                        pDTextBox.Text = Convert.ToString(p, 16).ToUpper();
                        FillValues(p, key, c);
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("This value is too big! Try again with a smaller one");
                    }
                }
            }
            else MessageBox.Show("Please fill in all required fields!");
        }

        private void FillValues(int p, int key, int c)
        {
            p2Label.Text = String.Format("P 2: {0}", Convert.ToString(p, 2));
            p10Label.Text = String.Format("P 10: {0}", Convert.ToString(p, 10));
            p16Label.Text = String.Format("P 16: {0}", Convert.ToString(p, 16).ToUpper());
            key2Label.Text = String.Format("Key 2: {0}", Convert.ToString(key, 2));
            key10Label.Text = String.Format("Key 10: {0}", Convert.ToString(key, 10));
            key16Label.Text = String.Format("Key 16: {0}", Convert.ToString(key, 16).ToUpper());
            c2Label.Text = String.Format("C 2: {0}", Convert.ToString(c, 2));
            c10Label.Text = String.Format("C 10: {0}", Convert.ToString(c, 10));
            c16Label.Text = String.Format("C 16: {0}", Convert.ToString(c, 16).ToUpper());
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            pETextBox.Text = "";
            cETextBox.Text = "";
            keyETextBox.Text = "";
            pDTextBox.Text = "";
            cDTextBox.Text = "";
            keyDTextBox.Text = "";
            p2Label.Text = "P 2:";
            p10Label.Text = "P 10:";
            p16Label.Text = "P 16:";
            key2Label.Text = "Key 2:";
            key10Label.Text = "Key 10:";
            key16Label.Text = "Key 16:";
            c2Label.Text = "C 2:";
            c10Label.Text = "C 10:";
            c16Label.Text = "C 16:";
        }

        private KeyPressEventArgs KeyPressHandler(KeyPressEventArgs e)
        {
            char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', '\b' };
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            if (symbols.Contains(e.KeyChar)) return e;
            e.Handled = true;
            return e;
        }

        private void pETextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = KeyPressHandler(e);
        }

        private void keyETextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = KeyPressHandler(e);
        }

        private void cDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = KeyPressHandler(e);
        }

        private void keyDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = KeyPressHandler(e);
        }

        private void TextBoxBlockHandler(bool encode)
        {
            if(encode)
            {
                if (pETextBox.Text != "" || keyETextBox.Text != "")
                {
                    cDTextBox.ReadOnly = true;
                    keyDTextBox.ReadOnly = true;
                }
                else
                {
                    cDTextBox.ReadOnly = false;
                    keyDTextBox.ReadOnly = false;
                }
            }
            else
            {
                if (cDTextBox.Text != "" || keyDTextBox.Text != "")
                {
                    pETextBox.ReadOnly = true;
                    keyETextBox.ReadOnly = true;
                }
                else
                {
                    pETextBox.ReadOnly = false;
                    keyETextBox.ReadOnly = false;
                }
            }
        }

        private void pETextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxBlockHandler(true);
        }

        private void keyETextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxBlockHandler(true);
        }

        private void cDTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxBlockHandler(false);
        }

        private void keyDTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxBlockHandler(false);
        }
    }
}
