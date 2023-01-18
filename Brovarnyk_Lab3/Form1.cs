using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brovarnyk_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MyShowToolTip(TextBox tb, byte[] arr)
        {
            //string hexValues = BitConverter.ToString(arr);
            string binValues = "";
            for(int i = 0; i < arr.Length; i++)
            {
                binValues += Convert.ToString(arr[i], 2)+" ";
            }
            //toolTipHEX.SetToolTip(tb, hexValues);
            toolTipHEX.SetToolTip(tb, binValues);
        }

        byte[] myXOR(byte[] textArr , byte[] keyArr)
        {
            int textLength = textArr.Length;
            int keyLength = keyArr.Length;
            byte[] cipherArr = new byte[textLength];
            for(int i = 0; i < textLength; i++)
            {
                byte p = textArr[i];
                byte k = keyArr[i % keyLength]; // MOD operation
                byte c = (byte)(p ^ k); //XOR Operation
                cipherArr[i] = c;
            }
            return cipherArr;
        }

        string MyCipher(TextBox tbText, TextBox tbKey, TextBox tbCipher, string cipher = "")
        {
            string text = tbText.Text;
            byte[] textArr;
            if (cipher == "") textArr = Encoding.Unicode.GetBytes(text);
            else textArr = Encoding.Unicode.GetBytes(cipher);
            MyShowToolTip(tbText, textArr); //Create tooltip
            string key = tbKey.Text;
            byte[] keyArr = Encoding.Unicode.GetBytes(key);
            MyShowToolTip(tbKey, keyArr); //Create tooltip
            byte[] cipherArr = myXOR(textArr, keyArr);
            
            //string cipher = BitConverter.ToString(arr_cipher).Replace("-", "");
            cipher = Encoding.Unicode.GetString(cipherArr);
            tbCipher.Text = cipher;
            MyShowToolTip(tbCipher, cipherArr); //Create tooltip
            return cipher;
        }

        string MyCipher(TextBox tbText, TextBox tbCipher, string cipher = "")
        {
            //Encoding.GetEncoding(tbText.Text);
            string text = tbText.Text;
            byte[] textArr;
            if (cipher == "") textArr = Encoding.Unicode.GetBytes(text);
            else textArr = Encoding.Unicode.GetBytes(cipher);
            MyShowToolTip(tbText, textArr); //Create tooltip
            cipher = text;
            tbCipher.Text = cipher;
            MyShowToolTip(tbCipher, textArr); //Create tooltip
            return cipher;
        }

        private void xorButton_Click(object sender, EventArgs e)
        {
            string cipher = "";
            if (string.IsNullOrEmpty(keyETextBox.Text))
            {
                //MessageBox.Show("Key field is not supposed to be clear!");
                //keyETextBox.Focus();
                cipher = MyCipher(pETextBox, cETextBox); //Encoding
                pDTextBox.Text = cETextBox.Text;
                keyDTextBox.Text = keyETextBox.Text;
                MyCipher(pDTextBox, cDTextBox, cipher); //Decoding
                return;
            }
            cipher = MyCipher(pETextBox, keyETextBox, cETextBox); //Encoding
            pDTextBox.Text = cETextBox.Text;
            keyDTextBox.Text = keyETextBox.Text;
            MyCipher(pDTextBox, keyDTextBox, cDTextBox, cipher); //Decoding
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            pETextBox.Text = "";
            keyETextBox.Text = "";
            cETextBox.Text = "";
            pDTextBox.Text = "";
            keyDTextBox.Text = "";
            cDTextBox.Text = "";
        }
    }

    
}
