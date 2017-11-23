using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsimetricEncryption
{
    public class EncryptionClass
    {
        public RSACryptoServiceProvider RSA { set; get; }
        public EncryptionClass()
        {
            RSA = new RSACryptoServiceProvider();
        }
        public byte[] CreatePublicKeys()
        {
            String xmlPublicKey = RSA.ToXmlString(true);
            return Encoding.ASCII.GetBytes(xmlPublicKey);
        }
        public byte[] CreatePrivateKeys()
        {
            String xmlPrivateKey = RSA.ToXmlString(true);
            return Encoding.ASCII.GetBytes(xmlPrivateKey);
        }
        public static byte[] EncryptText(String message,String publicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(publicKey);
            byte[] encryptedData = rsa.Encrypt(Encoding.ASCII.GetBytes(message),false);
            return encryptedData;
        }
        public static byte[] DecryptText(String message, String privateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(privateKey);
            byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(message), false);
            return decryptedData;
        }
    }
}