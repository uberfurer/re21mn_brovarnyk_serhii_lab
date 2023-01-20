using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Brovarnyk_Lab5
{
    public partial class Form1 : Form
    {
        byte[] inArr = new byte[0];
        byte[] outArr = new byte[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void inFOpenBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                inFTextBox.Text = fileDialog.FileName;
                string path = inFTextBox.Text;

                if (path == "")
                {
                    MessageBox.Show("Empty File path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inFOpenBtn.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (!File.Exists(path))
                {
                    MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inFOpenBtn.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.inArr = File.ReadAllBytes(path);
                inFSizeLabel.Text = String.Format("= {0:.000} Mb", (double)this.inArr.Length/(1024.0*1024.0));
            }
            this.Cursor = Cursors.Default;
        }

        private void outFSaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = "MyKey";
            fileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.CreatePrompt = true;
            fileDialog.OverwritePrompt = true;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                outFTextBox.Text = fileDialog.FileName;
                string path = outFTextBox.Text;

                if (path == "")
                {
                    MessageBox.Show("Empty Key file path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    outFSaveBtn.Focus();
                    return;
                }
            }
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            string key = "";
            string path = outFTextBox.Text;
            DateTime startTime;
            DateTime finishTime;
            TimeSpan allTime;
            totalTimeLabel.Text = "0:00:00:00.00";

            if (path == "")
            {
                MessageBox.Show("Wrong Key file path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                outFSaveBtn.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            startTime = DateTime.Now;

            this.outArr = MyEncoding(inArr);
            File.WriteAllBytes(path, this.outArr);
            outFSizeLabel.Text = String.Format("= {0} b", this.outArr.Length);
            key = BitConverter.ToString(outArr).Replace("-", "");
            finishTime = DateTime.Now;
            allTime = finishTime - startTime;
            totalTimeLabel.Text = allTime.ToString(@"d\:hh\:mm\:ss\.fff");

            MessageBox.Show("Result Key: " + key, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Cursor = Cursors.Default;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inArr = new byte[0];
            outArr = new byte[0];
            inFTextBox.Text = "";
            outFTextBox.Text = "";
            totalTimeLabel.Text = "0:00:00:00.000";
            inFSizeLabel.Text = "???";
            outFSizeLabel.Text = "???";
            crcRadioBtn.Checked = false;
            hashRadioBtn.Checked = false;
            md5RadioBtn.Checked = false;
            ripeRadioBtn.Checked = false;
            sha1RadioBtn.Checked = false;
            sha256RadioBtn.Checked = false;
            sha384RadioBtn.Checked = false;
            sha512RadioBtn.Checked = false;
        }

        private void authorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("\t Student \r\n Brovarnyk S. A. \r\n RTF - Applied Radio Electronics \r\n\t Lecturer \r\n Navrotskyi D. O.", "Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void descriptionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("File Control Sum generator", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private byte[] MyEncoding(byte[] inArr)
        {
            byte[] result = { 0 };
            if (crcRadioBtn.Checked == true)
            {
                uint a = CRC.CRC32(inArr);
                return BitConverter.GetBytes(a);
            }
            if (hashRadioBtn.Checked == true)
            {
                HashAlgorithm sha = KeyedHashAlgorithm.Create();
                return sha.ComputeHash(inArr);
            }
            if (ripeRadioBtn.Checked == true)
            {
                HashAlgorithm sha = RIPEMD160.Create();
                return sha.ComputeHash(inArr);
            }
            if (md5RadioBtn.Checked == true)
            {
                HashAlgorithm sha = MD5.Create();
                return sha.ComputeHash(inArr);
            }
            if (sha1RadioBtn.Checked == true)
            {
                HashAlgorithm sha = SHA1.Create();
                return sha.ComputeHash(inArr);
            }
            if (sha256RadioBtn.Checked == true)
            {
                HashAlgorithm sha = SHA256.Create();
                return sha.ComputeHash(inArr);
            }
            if (sha384RadioBtn.Checked == true)
            {
                HashAlgorithm sha = SHA384.Create();
                return sha.ComputeHash(inArr);
            }
            if (sha512RadioBtn.Checked == true)
            {
                HashAlgorithm sha = SHA512.Create();
                return sha.ComputeHash(inArr);
            }
            return result;
        }
    }
}
