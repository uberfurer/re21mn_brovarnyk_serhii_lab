using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Media;

namespace Brovarnyk_Lab6
{
    public partial class Form1 : Form
    {
        byte[] fileArr = new byte[0];
        byte[] randomArr = new byte[0];
        byte[] resultArr = new byte[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            keyLengthComboBox.SelectedItem = "8";
            viewPassCheckBox.Checked = false;
        }

        private void openKeyBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = "MyKey";
            fileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.CreatePrompt = true;
            fileDialog.OverwritePrompt = true;
            fileDialog.RestoreDirectory = true;

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                openKPathBox.Text = fileDialog.FileName;

                try
                {
                    string path = openKPathBox.Text;
                    this.randomArr = File.ReadAllBytes(path);
                    keyHEXTextBox.Text = StringHEX(this.randomArr);
                    keyLengthComboBox.Text = this.randomArr.Length.ToString();
                }
                catch(Exception)
                {
                    this.randomArr = new byte[0];
                    File.Create(openKPathBox.Text);
                }
            }
        }

        private void genKeyBtn_Click(object sender, EventArgs e)
        {
            string path = openKPathBox.Text;
            DateTime startTime;
            DateTime finishTime;
            TimeSpan allTime;
            totTimeLabel.Text = "00:00.00";

            if(path == "")
            {
                MessageBox.Show("Wrong Key file path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openKPathBox.Focus();
                return;
            }

            if(!File.Exists(path))
            {
                MessageBox.Show("Key file does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openKeyBtn.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            startTime = DateTime.Now;

            if(keyRNGRadioBtn.Checked)
            {
                this.randomArr = KeyGen.GenerateKey(int.Parse(keyLengthComboBox.Text));
            }
            if(keyExtRadioBtn.Checked)
            {
                PasswordGen password = new PasswordGen(passTextBox.Text, keyLengthComboBox.Text);
                this.randomArr = password.Result;
            }

            File.WriteAllBytes(path, this.randomArr);
            keyHEXTextBox.Text = StringHEX(this.randomArr);
            finishTime = DateTime.Now;
            allTime = finishTime - startTime;
            totTimeLabel.Text = allTime.ToString(@"hh\:mm\:ss");

            this.Cursor = Cursors.Default;
            SystemSounds.Hand.Play();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                this.fileArr = File.ReadAllBytes(path);
                openFileStLabel.Text = "File";
                openFileStLabel.ForeColor = Color.Green;
                encodingStLabel.Text = "(none)";
                encodingStLabel.ForeColor = Color.Red;
                saveFileStLabel.Text = "(none)";
                saveFileStLabel.ForeColor = Color.Red;
                SystemSounds.Beep.Play();
            }
            this.Cursor = Cursors.Default;
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            int fileLength = this.fileArr.Length;
            if(fileLength == 0)
            {
                MessageBox.Show("Something goes wrong with your file!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int keyLength = this.randomArr.Length;
            if(keyLength == 0)
            {
                MessageBox.Show("Something goes wrong with your key!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            this.resultArr = new byte[fileLength];
            for(int i = 0; i < fileLength; i++)
            {
                this.resultArr[i] = (byte)(this.fileArr[i] ^ this.randomArr[i % keyLength]);
            }

            encodingStLabel.Text = "File";
            encodingStLabel.ForeColor = Color.Green;
            saveFileStLabel.Text = "(none)";
            saveFileStLabel.ForeColor = Color.Red;
            SystemSounds.Beep.Play();
            this.Cursor = Cursors.Default;
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            fileDialog.CreatePrompt = true;
            fileDialog.OverwritePrompt = true;

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                File.WriteAllBytes(path, this.resultArr);

                if (this.resultArr.Length == 0)
                {
                    MessageBox.Show("Something goes wrong with ciphering!" + Environment.NewLine + "file has been saved, but" + "\r \n" + "0 bytes", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                }

                saveFileStLabel.Text = "File";
                saveFileStLabel.ForeColor = Color.Green;
                SystemSounds.Beep.Play();
            }
            this.Cursor = Cursors.Default;
        }

        private void keyLengthComboBox_TextChanged(object sender, EventArgs e)
        {
            string str = keyLengthComboBox.Text;
            if(str != "")
            {
                keyLengthLabel.Text = Convert.ToString(Convert.ToInt32(str)*8);
            }
        }

        private void keyLengthComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void editHEXCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editHEXCheckBox.Checked) keyHEXTextBox.ReadOnly = false;
            else
            {
                keyHEXTextBox.ReadOnly = true;

                string path = openKPathBox.Text;

                if(path == "")
                {
                    MessageBox.Show("Wrong path to key file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editHEXCheckBox.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    openKPathBox.Focus();
                    return;
                }
                if(!File.Exists(path))
                {
                    MessageBox.Show("Key file does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editHEXCheckBox.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    openKeyBtn.Focus();
                    return;
                }

                this.randomArr = StringToByteArr(keyHEXTextBox.Text);

                File.WriteAllBytes(path, this.randomArr);
            }
        }

        private void keyHEXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if(!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || c == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void keyRNGRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(keyRNGRadioBtn.Checked)
            {
                genKeyBtn.ImageIndex = 0;
                encodeBtn.ImageIndex = 0;
                passTextBox.ForeColor = Color.DarkGreen;
            }
        }

        private void keyExtRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (keyExtRadioBtn.Checked)
            {
                genKeyBtn.ImageIndex = 1;
                encodeBtn.ImageIndex = 1;
                passTextBox.ForeColor = Color.Black;
            }
        }

        private void authorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("\t Student \r\n Brovarnyk S. A. \r\n RTF - Applied Radio Electronics \r\n\t Lecturer \r\n Navrotskyi D. O.", "Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viewPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(viewPassCheckBox.Checked)
            {
                passTextBox.PasswordChar = '\0';
            }
            else
            {
                passTextBox.PasswordChar = '*';
            }
        }

        string StringHEX(byte[] randArr)
        {
            BitArray randomBitArr = new BitArray(randomArr);
            string hexText = BitConverter.ToString(randomArr);
            return hexText.Replace("-", "");
        }

        byte[] StringToByteArr(string hex)
        {
            int length = hex.Length;
            if(length % 2 == 1)
            {
                hex = "0" + hex;
                keyHEXTextBox.Text = hex;
                length++;
            }

            int halfLength = length / 2;
            byte[] bs = new byte[halfLength];

            for(int i = 0; i != halfLength; i++)
            {
                bs[i] = (byte)Int32.Parse(hex.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return bs;
        }

        private string ToDigitString(BitArray arr)
        {
            var builder = new StringBuilder();
            foreach(var bit in arr.Cast<bool>())
            {
                builder.Append(bit ? "1" : "0");
            }
            return builder.ToString();
        }

    }
}
