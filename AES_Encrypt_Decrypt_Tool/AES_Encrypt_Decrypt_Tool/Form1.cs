using Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AES_Encrypt_Decrypt_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string IV = txtIV.Text;
                string Key = txtKey.Text;
                if(string.IsNullOrEmpty(txtInputData.Text))
                {
                    MessageBox.Show("Input Value should not be blank.");
                    return;
                }
                if (string.IsNullOrEmpty(txtIV.Text) || string.IsNullOrEmpty(txtKey.Text))
                {
                    MessageBox.Show("AES IV and Key should not be blank.");
                    return;
                }
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                aes.BlockSize = 128;
                aes.KeySize = 256;
                aes.IV = UTF8Encoding.UTF8.GetBytes(IV);
                aes.Key = UTF8Encoding.UTF8.GetBytes(Key);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                byte[] data = Encoding.UTF8.GetBytes(txtInputData.Text);
                using (ICryptoTransform encrypt = aes.CreateEncryptor())
                {
                    byte[] dest = encrypt.TransformFinalBlock(data, 0, data.Length);
                    txtOutputData.Text = Convert.ToBase64String(dest);
                }
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                Loger.WriteErrorLog(null, Ex);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {

                string IV = txtIV.Text;
                string Key = txtKey.Text;
                if (string.IsNullOrEmpty(txtInputData.Text))
                {
                    MessageBox.Show("Input Value should not be blank.");
                    return;
                }
                if (string.IsNullOrEmpty(txtIV.Text) || string.IsNullOrEmpty(txtKey.Text))
                {
                    MessageBox.Show("AES IV and Key should not be blank.");
                    return;
                }
                string plaintext = null;
                using (AesManaged aes = new AesManaged())
                {
                    byte[] cipherText = Convert.FromBase64String(txtInputData.Text);
                    byte[] aesIV = UTF8Encoding.UTF8.GetBytes(IV);
                    byte[] aesKey = UTF8Encoding.UTF8.GetBytes(Key);
                    ICryptoTransform decryptor = aes.CreateDecryptor(aesKey, aesIV);
                    using (MemoryStream ms = new MemoryStream(cipherText))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cs))
                                plaintext = reader.ReadToEnd();
                            txtOutputData.Text = plaintext;
                        }
                    }
                }
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                Loger.WriteErrorLog(null, Ex);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIV.Text = string.Empty;
            txtKey.Text = string.Empty;
            txtInputData.Text = string.Empty;
            txtOutputData.Text = string.Empty;
        }
    }
}
