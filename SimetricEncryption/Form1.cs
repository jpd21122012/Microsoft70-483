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

namespace SimetricEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            String message = tbResult.Text;
            String password = tbKey.Text;
            byte[] textByte;
            textByte = Encoding.Default.GetBytes(message);
            String result = TextDecryption(textByte, (new PasswordDeriveBytes(password, null)).GetBytes(32));
            tbMessage.Text = result;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            String message = tbMessage.Text;
            String password = tbKey.Text;
            String result = TextEncryption(message,(new PasswordDeriveBytes(password,null)).GetBytes(32));
            tbResult.Text = result;
        }
        string TextEncryption(string message, byte[] key)
        {
            Rijndael rijndael = Rijndael.Create();
            byte[] encryptByte = null;
            byte[] outputByte = null;
            try
            {
                rijndael.Key = key;
                rijndael.GenerateIV();
                byte[] inputByte = Encoding.UTF8.GetBytes(message);
                encryptByte = rijndael.CreateEncryptor().TransformFinalBlock(inputByte, 0, inputByte.Length);
                outputByte = new byte[rijndael.IV.Length + encryptByte.Length];
                rijndael.IV.CopyTo(outputByte, 0);
                encryptByte.CopyTo(outputByte, rijndael.IV.Length);
                ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                rijndael.Clear();
            }
            string output = Encoding.Default.GetString(outputByte);
            return output;
        }
        string TextDecryption(byte[] cryptedData, byte[] key)
        {
            string decryptedText=string.Empty;
            Rijndael rijndael = Rijndael.Create();
            byte[] temp = new byte[rijndael.IV.Length];
            byte[] cryptedByte = new byte[cryptedData.Length-rijndael.IV.Length];

            try
            {
                rijndael.Key = key;
                Array.Copy(cryptedData,temp,temp.Length);
                Array.Copy(cryptedData,temp.Length, cryptedByte,0,cryptedByte.Length);
                rijndael.IV = temp;
                decryptedText = Encoding.UTF8.GetString((rijndael.CreateDecryptor()).TransformFinalBlock(cryptedByte,0,cryptedByte.Length));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                rijndael.Clear();
            }
            return decryptedText;
        }
    }
}