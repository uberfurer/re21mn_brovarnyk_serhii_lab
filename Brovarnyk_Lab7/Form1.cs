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
using System.Security.Cryptography;
using System.Collections;
using System.Threading;

namespace Brovarnyk_Lab7
{
    public partial class Form1 : Form
    {
        byte[] fileArr = new byte[0];
        byte[] resultArr = new byte[0];
        byte[] key = new byte[0];
        byte[] IV = new byte[0];

        RadioButton lastRB = null;
        RadioButton currentRB = null;

        string fileStr = "";

        public Form1()
        {
            InitializeComponent();
            keyLengthComboBox.SelectedIndex = 0;
            vectorTextBox.Text = "00-00-00-00-00-00-00-00";
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Brovarnyk Serhii!\r\nProgram: File encrypter/decrypter", "About program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//TODO

        private void inEntropyStLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(inEntropyStLabel.Text);
        }

        private void outEntropyStLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(inEntropyStLabel.Text);
        }

        private void openFBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                if (path == "")
                {
                    MessageBox.Show("Empty File path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    openFBtn.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                if (!File.Exists(path))
                {
                    MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    openFBtn.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                openFPathBox.Text = path;
                this.fileArr = File.ReadAllBytes(path);
                inEntropyStLabel.Text = String.Format("{0:0.000}", CalculateEntropy(this.fileArr));
                //// Temporary code
                this.fileStr = File.ReadAllText(path);
                ////
                sizeStLabel.Text = String.Format("- {0:0.000} Mb ({1} bytes)", (double)this.fileArr.Length / (1024.0 * 1024.0), fileArr.Length);
            }
            this.Cursor = Cursors.Default;
        }

        private void saveFBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.CreatePrompt = true;
            fileDialog.OverwritePrompt = true;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                if (path == "")
                {
                    MessageBox.Show("Empty Key file path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveFBtn.Focus();
                    return;
                }
                saveFPathBox.Text = path;
            }
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.CreatePrompt = true;
            fileDialog.OverwritePrompt = true;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                if (path == "")
                {
                    MessageBox.Show("Empty settings file path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveSettingsBtn.Focus();
                    return;
                }
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                string settings = "";
                if (aesRadioBtn.Checked) settings += "aesRadioBtn*";
                if (rijndaelRadioBtn.Checked) settings += "rijndaelRadioBtn*";
                if (desRadioBtn.Checked) settings += "desRadioBtn*";
                if (trDESRadioBtn.Checked) settings += "trDESRadioBtn*";
                if (rc2RadioBtn.Checked) settings += "(rc2RadioBtn*";
                settings += genVecCheckBox.Checked ? "no_vector*" : "vector*";
                settings += keyLengthComboBox.Text + "*";
                settings += keyTextBox.Text + "*";
                settings += vectorTextBox.Text;
                File.WriteAllText(path, settings);
            }
            this.Cursor = Cursors.Default;
        }

        private void openSettingsBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                if (path == "")
                {
                    MessageBox.Show("Empty setting file path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    openSettingsBtn.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                if (!File.Exists(path))
                {
                    MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    openSettingsBtn.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                //Setting restoration
                string all_settings = File.ReadAllText(path);
                string[] settings = all_settings.Split('*');
                switch(settings[0])
                {
                    case "aesRadioBtn":
                        aesRadioBtn.Checked = true;
                        break;
                    case "rijndaelRadioBtn":
                        rijndaelRadioBtn.Checked = true;
                        break;
                    case "desRadioBtn":
                        desRadioBtn.Checked = true;
                        break;
                    case "trDESRadioBtn":
                        trDESRadioBtn.Checked = true;
                        break;
                    case "rc2RadioBtn":
                        rc2RadioBtn.Checked = true;
                        break;
                    default:
                        aesRadioBtn.Checked = true;
                        break;
                }
                if (settings[1] == "no_vector") genVecCheckBox.Checked = true;
                if (settings[1] == "vector") genVecCheckBox.Checked = false;
                keyLengthComboBox.SelectedItem = settings[2];
                keyTextBox.Text = settings[3];
                this.key = StringToByteArr(settings[3]);
                if (settings[1] == "vector") { vectorTextBox.Text = settings[4]; this.IV = StringToByteArr(settings[4]);}
            }
            this.Cursor = Cursors.Default;
        }

        private void keyLengthComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genKeyBtn_Click(object sender, EventArgs e)
        {
            this.key = GenerateKey();
            keyTextBox.Text = StringHEX(this.key);
        }

        private void genVectorBtn_Click(object sender, EventArgs e)
        {
            this.IV = GenerateIV();
            vectorTextBox.Text = StringHEX(this.IV);
        }

        private void genVecCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(genVecCheckBox.Checked)
            {
                vectorTextBox.Text = "00-00-00-00-00-00-00-00";
                vectorTextBox.Enabled = false;
                genVectorBtn.Enabled = false;
            }
            else
            {
                vectorTextBox.Enabled = true;
                vectorTextBox.Text = StringHEX(IV);
                genVectorBtn.Enabled = true;
            }
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            string path = saveFPathBox.Text;
            DateTime startTime;
            DateTime finishTime;
            TimeSpan allTime;
            totalTimeLabel.Text = "0:00:00:00.000";

            if (path == "")
            {
                MessageBox.Show("Wrong output file path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saveFPathBox.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            startTime = DateTime.Now;
            this.resultArr = MyEncoding(fileStr);
            File.WriteAllBytes(path, this.resultArr);
            finishTime = DateTime.Now;
            allTime = finishTime - startTime;
            totalTimeLabel.Text = allTime.ToString(@"d\:hh\:mm\:ss\.fff");
            outEntropyStLabel.Text = String.Format("{0:0.000}", CalculateEntropy(this.resultArr));
            this.Cursor = Cursors.Default;
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
            string path = saveFPathBox.Text;
            DateTime startTime;
            DateTime finishTime;
            TimeSpan allTime;
            totalTimeLabel.Text = "0:00:00:00.000";

            if (path == "")
            {
                MessageBox.Show("Wrong output file path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saveFPathBox.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            startTime = DateTime.Now;
            try
            {
                this.resultArr = Encoding.ASCII.GetBytes(MyDecoding(this.fileArr));
            }
            catch(Exception)
            {
                MessageBox.Show("Wrong key or init vector!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openSettingsBtn.Focus();
                this.Cursor = Cursors.Default;
                return;
            }
            File.WriteAllBytes(path, this.resultArr);
            finishTime = DateTime.Now;
            allTime = finishTime - startTime;
            totalTimeLabel.Text = allTime.ToString(@"d\:hh\:mm\:ss\.fff");

            this.Cursor = Cursors.Default;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {

        }

        private void aesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(aesRadioBtn.Checked)
            {
                currentRB = aesRadioBtn;
                /// - Key Length Collection fill
                keyLengthComboBox.Items.Clear();
                keyLengthComboBox.Items.AddRange(new string[] { "128", "192", "256" });
                ///

                /// - Combobox Params
                keyLengthComboBox.Enabled = true;
                keyLengthComboBox.SelectedIndex = 0;
                ///

                /// Generate AES key and set to keyTextBox and vectorTextBox
                Tuple<byte[], byte[]> keys = GenerateKeys();
                this.key = keys.Item1;
                this.IV = keys.Item2;
                keyTextBox.Text = StringHEX(this.key);
                if(vectorTextBox.Enabled) vectorTextBox.Text = StringHEX(this.IV);
                ///

            }
        }

        private void rijndaelRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(rijndaelRadioBtn.Checked)
            {
                currentRB = rijndaelRadioBtn;

                /// - Key Length Collection fill
                keyLengthComboBox.Items.Clear();
                keyLengthComboBox.Items.AddRange(new string[] { "128", "192", "256" });
                ///

                /// - Combobox Params
                keyLengthComboBox.Enabled = true;
                keyLengthComboBox.SelectedIndex = 0;
                ///

                /// Generate Rijndael key and set to keyTextBox and vectorTextBox
                Tuple<byte[], byte[]> keys = GenerateKeys();
                this.key = keys.Item1;
                this.IV = keys.Item2;
                keyTextBox.Text = StringHEX(this.key);
                if (vectorTextBox.Enabled) vectorTextBox.Text = StringHEX(this.IV);
                ///
            }
        }

        private void desRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(desRadioBtn.Checked)
            {
                currentRB = desRadioBtn;

                /// - Key Length Collection fill
                keyLengthComboBox.Items.Clear();
                keyLengthComboBox.Items.Add("64");
                ///

                /// - Combobox Params
                keyLengthComboBox.Enabled = false;
                keyLengthComboBox.SelectedIndex = 0;
                ///

                /// Generate Rijndael key and set to keyTextBox and vectorTextBox
                Tuple<byte[], byte[]> keys = GenerateKeys();
                this.key = keys.Item1;
                this.IV = keys.Item2;
                keyTextBox.Text = StringHEX(this.key);
                if (vectorTextBox.Enabled) vectorTextBox.Text = StringHEX(this.IV);
                ///
            }
        }

        private void trDESRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(trDESRadioBtn.Checked)
            {
                currentRB = trDESRadioBtn;

                /// - Key Length Collection fill
                keyLengthComboBox.Items.Clear();
                keyLengthComboBox.Items.AddRange(new string[] { "128", "192" });
                ///

                /// - Combobox Params
                keyLengthComboBox.Enabled = true;
                keyLengthComboBox.SelectedIndex = 0;
                ///

                /// Generate Rijndael key and set to keyTextBox and vectorTextBox
                Tuple<byte[], byte[]> keys = GenerateKeys();
                this.key = keys.Item1;
                this.IV = keys.Item2;
                keyTextBox.Text = StringHEX(this.key);
                if (vectorTextBox.Enabled) vectorTextBox.Text = StringHEX(this.IV);
                ///
            }
        }

        private void rc2RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(rc2RadioBtn.Checked)
            {
                currentRB = rc2RadioBtn;

                /// - Key Length Collection fill
                keyLengthComboBox.Items.Clear();
                keyLengthComboBox.Items.AddRange(new string[] { "40", "48", "56", "64", "72", "80", "88", "96", "104", "112", "120", "128" });
                ///

                /// - Combobox Params
                keyLengthComboBox.Enabled = true;
                keyLengthComboBox.SelectedIndex = 0;
                ///

                /// Generate Rijndael key and set to keyTextBox and vectorTextBox
                Tuple<byte[], byte[]> keys = GenerateKeys();
                this.key = keys.Item1;
                this.IV = keys.Item2;
                keyTextBox.Text = StringHEX(this.key);
                if (vectorTextBox.Enabled) vectorTextBox.Text = StringHEX(this.IV);
                ///
            }
        }

        private byte[] MyEncoding(string inStr)
        {
            byte[] result = { 0 };
            if (aesRadioBtn.Checked == true)
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = this.key;
                    if(genVecCheckBox.Checked)
                    {
                        try
                        {
                            aes.IV = this.key;
                        }
                        catch(Exception)
                        {
                            aes.IV = (byte[])this.key.Take(this.key.Length/2);
                        }
                    }
                    else
                    {
                        aes.IV = this.IV;
                    }
                    result =  Encryption.encryptAes(inStr, aes.Key, aes. IV);
                }
            }
            if (rijndaelRadioBtn.Checked == true)
            {
                using (Rijndael rijndael = Rijndael.Create())
                {
                    rijndael.Key = this.key;
                    if (genVecCheckBox.Checked)
                    {
                        rijndael.IV = this.key;
                    }
                    else
                    {
                        rijndael.IV = this.IV;
                    }
                    result = Encryption.encryptRijndael(inStr, rijndael.Key, rijndael.IV);
                }
            }
            if (desRadioBtn.Checked == true)
            {
                using (DES des = DES.Create())
                {
                    des.Key = this.key;
                    if (genVecCheckBox.Checked)
                    {
                        des.IV = this.key;
                    }
                    else
                    {
                        des.IV = this.IV;
                    }
                    result = Encryption.encryptDES(inStr, des.Key, des.IV);
                }
            }
            if (trDESRadioBtn.Checked == true)
            {
                using (TripleDES trDES = TripleDES.Create())
                {
                    trDES.Key = this.key;
                    if (genVecCheckBox.Checked)
                    {
                        try
                        {
                            trDES.IV = this.key;
                        }
                        catch (Exception)
                        {
                            trDES.IV = this.key.Take(this.key.Length / 2).ToArray();
                        }
                    }
                    else
                    {
                        trDES.IV = this.IV;
                    }
                    result = Encryption.encryptTrDES(inStr, trDES.Key, trDES.IV);
                }
            }
            if (rc2RadioBtn.Checked == true)
            {
                using (RC2 rc2 = RC2.Create())
                {
                    rc2.Key = this.key;
                    if (genVecCheckBox.Checked)
                    {
                        try
                        {
                            rc2.IV = this.key;
                        }
                        catch (Exception)
                        {
                            rc2.IV = this.key.Take(5).Union(this.key.Take(3)).ToArray();
                        }
                    }
                    else
                    {
                        rc2.IV = this.IV;
                    }
                    result = Encryption.encryptRC2(inStr, rc2.Key, rc2.IV);
                }
            }
            return result;
        }

        private string MyDecoding(byte[] arr)
        {

            string result = "";
            if (aesRadioBtn.Checked == true)
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = this.key;
                    if (genVecCheckBox.Checked)
                    {
                        aes.IV = this.key;
                    }
                    else
                    {
                        aes.IV = this.IV;
                    }
                    
                    result = Encryption.decryptAes(arr, aes.Key, aes.IV);
                }
            }
            if (rijndaelRadioBtn.Checked == true)
            {
                using (Rijndael rijndael = Rijndael.Create())
                {
                    rijndael.Key = this.key;
                    if (genVecCheckBox.Checked)
                    {
                        rijndael.IV = this.key;
                    }
                    else
                    {
                        rijndael.IV = this.IV;
                    }

                    result = Encryption.decryptRijndael(arr, rijndael.Key, rijndael.IV);
                }
            }
            if (desRadioBtn.Checked == true)
            {
                using (DES des = DES.Create())
                {
                    des.Key = this.key;
                    if (genVecCheckBox.Checked)
                    {
                        des.IV = this.key;
                    }
                    else
                    {
                        des.IV = this.IV;
                    }

                    result = Encryption.decryptDES(arr, des.Key, des.IV);
                }
            }
            if (trDESRadioBtn.Checked == true)
            {
                using (TripleDES trDES = TripleDES.Create())
                {
                    trDES.Key = this.key;
                    if (genVecCheckBox.Checked)
                    {
                        trDES.IV = this.key;
                    }
                    else
                    {
                        trDES.IV = this.IV;
                    }

                    result = Encryption.decrypTrDES(arr, trDES.Key, trDES.IV);
                }
            }
            if (rc2RadioBtn.Checked == true)
            {
                using (RC2 rc2 = RC2.Create())
                {
                    rc2.Key = this.key;
                    if (genVecCheckBox.Checked)
                    {
                        rc2.IV = this.key;
                    }
                    else
                    {
                        rc2.IV = this.IV;
                    }

                    result = Encryption.decryptRC2(arr, rc2.Key, rc2.IV);
                }
            }
            return result;
        }

        string StringHEX(byte[] randomArr)
        {
            BitArray randomBitArr = new BitArray(randomArr);
            string hexText = BitConverter.ToString(randomArr);
            return hexText;
        }

        Tuple<byte[], byte[]> GenerateKeys()
        {
            if(aesRadioBtn.Checked)
            {
                AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                provider.GenerateIV();
                return new Tuple<byte[], byte[]>(provider.Key, provider.IV);
            }
            if (rijndaelRadioBtn.Checked)
            {
                RijndaelManaged provider = new RijndaelManaged();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                provider.GenerateIV();
                return new Tuple<byte[], byte[]>(provider.Key, provider.IV);
            }
            if (desRadioBtn.Checked)
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                provider.GenerateIV();
                return new Tuple<byte[], byte[]>(provider.Key, provider.IV);
            }
            if (trDESRadioBtn.Checked)
            {
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                provider.GenerateIV();
                return new Tuple<byte[], byte[]>(provider.Key, provider.IV);
            }
            if (rc2RadioBtn.Checked)
            {
                RC2CryptoServiceProvider provider = new RC2CryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                provider.GenerateIV();
                return new Tuple<byte[], byte[]>(provider.Key, provider.IV);
            }
            return new Tuple<byte[], byte[]>(new byte[0], new byte[0]);
        }

        byte[] GenerateKey()
        {
            if (aesRadioBtn.Checked)
            {
                AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (rijndaelRadioBtn.Checked)
            {
                RijndaelManaged provider = new RijndaelManaged();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (desRadioBtn.Checked)
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (trDESRadioBtn.Checked)
            {
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (rc2RadioBtn.Checked)
            {
                RC2CryptoServiceProvider provider = new RC2CryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            return new byte[0];
        }

        byte[] GenerateIV()
        {
            if (aesRadioBtn.Checked)
            {
                AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (rijndaelRadioBtn.Checked)
            {
                RijndaelManaged provider = new RijndaelManaged();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (desRadioBtn.Checked)
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (trDESRadioBtn.Checked)
            {
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (rc2RadioBtn.Checked)
            {
                RC2CryptoServiceProvider provider = new RC2CryptoServiceProvider();
                provider.KeySize = Int32.Parse(keyLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            return new byte[0];
        }

        private void keyLengthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lastRB != currentRB)
            {
                ///Update Last RadioButton
                lastRB = currentRB;
                ///
                return;
            }
            Tuple<byte[], byte[]> keys = GenerateKeys();
            this.key = keys.Item1;
            this.IV = keys.Item2;
            keyTextBox.Text = StringHEX(this.key);
            vectorTextBox.Text = StringHEX(this.IV);
        }

        private double CalculateEntropy(byte[] arr)
        {
            double entropy = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    entropy += -((double)arr[i] / (double)arr.Length) * Math.Log((double)arr[i] / (double)arr.Length, 2.0);
                }
            }
            return entropy;
        }

        byte[] StringToByteArr(string hex)
        {
            string tmp = hex.Replace("-", "");
            int length = tmp.Length;
            if (length % 2 == 1)
            {
                tmp = "0" + tmp;
                length++;
            }

            int halfLength = length / 2;
            byte[] bs = new byte[halfLength];

            for (int i = 0; i != halfLength; i++)
            {
                bs[i] = (byte)Int32.Parse(tmp.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return bs;
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void keyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] chars = {'0','1','2','3','4','5','6','7','8','9', 'A','B','C','D','E','F'};
            if (!chars.Contains(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                if (chars.Contains(e.KeyChar.ToString().ToUpper().ToCharArray()[0]))
                {
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                    string result = "";
                    foreach (string stByte in keyTextBox.Text.Split('-'))
                    {
                        if (stByte.Length == 2)
                        {
                            result += stByte;
                        }
                    }
                    this.key = StringToByteArr(result);
                    return;
                }
                e.Handled = true;
                return;
            }
            else
            {
                string result = "";
                foreach (string stByte in keyTextBox.Text.Split('-'))
                {
                    if (stByte.Length == 2)
                    {
                        result += stByte;
                    }
                }
                this.key = StringToByteArr(result);
            }

        }

        private void vectorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vectorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            if (!chars.Contains(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                if (chars.Contains(e.KeyChar.ToString().ToUpper().ToCharArray()[0]))
                {
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                    string result = "";
                    foreach (string stByte in vectorTextBox.Text.Split('-'))
                    {
                        if (stByte.Length == 2)
                        {
                            result += stByte;
                        }
                    }
                    this.IV = StringToByteArr(result);
                    return;
                }
                e.Handled = true;
                return;
            }
            else
            {
                string result = "";
                foreach (string stByte in vectorTextBox.Text.Split('-'))
                {
                    if (stByte.Length == 2)
                    {
                        result += stByte;
                    }
                }
                this.IV = StringToByteArr(result);
            }
        }
    }
}
