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

namespace AsimetricEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            EncryptionClass encryption = new EncryptionClass();
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog()==DialogResult.OK)
            {
                String folderFile = folder.SelectedPath;
                FileStream fileStream = new FileStream(Path.Combine(folderFile,"PublicKey.xml"),FileMode.Create,FileAccess.Write);
                byte[] publicKey = encryption.CreatePublicKeys();
                fileStream.Write(publicKey,0,publicKey.Length);
                fileStream.Close();
                fileStream = new FileStream(Path.Combine(folderFile, "PrivateKey.xml"), FileMode.Create, FileAccess.Write);
                byte[] privateKey = encryption.CreatePrivateKeys();
                fileStream.Write(privateKey, 0, privateKey.Length);
                fileStream.Close();
                MessageBox.Show("Keys successfully stored");
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Public Keys (*.xml)|*.xml";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                Stream temp = openFileDialog.OpenFile();
                String publicKeyXml = new StreamReader(temp).ReadToEnd();
                byte[] encryptedData = EncryptionClass.EncryptText(tbMessage.Text,publicKeyXml);
                tbResult.Text = Convert.ToBase64String(encryptedData);
                tbMessage.Clear();
                tbMessage.Text = tbResult.Text;
                tbResult.Clear();
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Private Keys (*.xml)|*.xml";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                Stream temp = openFileDialog.OpenFile();
                String privateKeyXml = new StreamReader(temp).ReadToEnd();
                byte[] decryptedData = EncryptionClass.DecryptText(tbMessage.Text,privateKeyXml);
                tbResult.Text = Encoding.ASCII.GetString(decryptedData);
            }
        }
    }
}
