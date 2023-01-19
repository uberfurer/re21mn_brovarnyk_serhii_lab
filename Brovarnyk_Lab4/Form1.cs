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
using System.Diagnostics;
using System.Security.Cryptography;

namespace Brovarnyk_Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fileDialog.FilterIndex = 2;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = fileDialog.FileName;
                    openFPathBox.Text = path;
                }
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                saveFPathBox.Text = path;
            }
        }

        private void openKeyBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = fileDialog.FileName;
                    keyPathBox.Text = path;
                    //long keyLength = new FileInfo(kPath).Length;
                    //keySizeLabel.Text = keyArr.Length.ToString() + "b";
                    keySizeLabel.Text = new FileInfo(path).Length.ToString() + "b";
                }
            }
        }

        private void saveKeyBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                keyPathBox.Text = path;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string fPath = openFPathBox.Text;
            string sPath = saveFPathBox.Text;
            string kPath = keyPathBox.Text;
            if(File.Exists(fPath))
            {
                string saveDirPath = Path.GetDirectoryName(sPath);
                if(Directory.Exists(saveDirPath))
                {
                    if(File.Exists(kPath))
                    {
                        long fileLength = new FileInfo(fPath).Length;
                        long keyLength = new FileInfo(kPath).Length;
                        //if(fileLength == keyLength)
                        //{
                            Stopwatch watch = new Stopwatch();
                            watch.Start();
                            byte[] cipherArr = MyCipherXOR(fPath, kPath);
                            MySaveToFile(cipherArr, sPath);
                            watch.Stop();
                            totTimeLabel.Text = watch.Elapsed.ToString(@"mm\:ss\.fff");
                            totTimeLabel.Update();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("File size and key size mismatch!");
                        //    openKeyBtn.Focus();
                        //    return;
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Wrong key file!");
                        genBtn.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong output file!");
                    saveFileBtn.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Wrong input file!");
                openFileBtn.Focus();
                return;
            }
            Cursor.Current = Cursors.Default;
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Generate New Key?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                string path = openFPathBox.Text;
                if(File.Exists(path))
                {
                    string keyPath = keyPathBox.Text;
                    string dirKeyPath = Path.GetDirectoryName(keyPath);
                    if(Directory.Exists(dirKeyPath))
                    {
                        long fileLength = new FileInfo(path).Length;
                        byte[] keyArr = new byte[fileLength];
                        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                        rng.GetBytes(keyArr);

                        using (FileStream fs = File.Create(keyPath))
                        {
                            fs.Write(keyArr, 0, keyArr.Length);
                            fs.Close();
                        }
                        keySizeLabel.Text = keyArr.Length.ToString() + "b";
                    }
                    else
                    {
                        MessageBox.Show("Please select the correct folder path!");
                        openKeyBtn.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select the correct file path!");
                    openFileBtn.Focus();
                    return;
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private byte[] MyCipherXOR(string fPath, string kPath)
        {
            byte[] inputArr = File.ReadAllBytes(fPath);
            byte[] keyArr = File.ReadAllBytes(kPath);
            int inpLength = inputArr.Length;
            int keyLength = keyArr.Length;
            byte[] cipherArr = new byte[inpLength];
            for (int i = 0; i < inpLength; i++)
            {
                cipherArr[i] = (byte)(inputArr[i] ^ keyArr[i % keyLength]);
            }
            return cipherArr;
        }
        private void MySaveToFile(byte[] cipherArr, string sPath)
        {
            using (FileStream fs = File.Create(sPath))
            {
                fs.Write(cipherArr, 0, cipherArr.Length);
                fs.Close();
            }
        }
    }
}
