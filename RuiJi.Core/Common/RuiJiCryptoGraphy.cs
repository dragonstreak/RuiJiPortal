using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class RuiJiCryptoGraphy
    {
        // Fields
        private const string Security_Key = "Ruiji123@sh";
        private const string KeyString = "oFidztn4tdaBDMzDRtVkmopnirM64oW8";
        private const string IVString = "YcEJsucmZoY=";
        private byte[] KEY;
        private byte[] IV;

        public static readonly RuiJiCryptoGraphy Instance = new RuiJiCryptoGraphy();

        private MD5CryptoServiceProvider _hashProvider;
        private TripleDESCryptoServiceProvider _symmetricProvider;


        private RuiJiCryptoGraphy()
        {
            _hashProvider = new MD5CryptoServiceProvider();
            _symmetricProvider = new TripleDESCryptoServiceProvider();
            KEY = Convert.FromBase64String(KeyString);
            IV = Convert.FromBase64String(IVString);
        }

        public bool CompareHash(string plaintext, string hashedText)
        {
            string hashPlaintext = CreateHash(plaintext);

            return string.Equals(hashPlaintext, hashedText, StringComparison.Ordinal);
        }
        
        public string CreateHash(string plaintext)
        {
            byte[] plainByte = Encoding.UTF8.GetBytes(plaintext + Security_Key);
            byte[] hashByte = _hashProvider.ComputeHash(plainByte);
            return Convert.ToBase64String(hashByte);
        }

        public string DecryptSymmetric(string ciphertextBase64)
        {
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, _symmetricProvider.CreateDecryptor(KEY, IV), CryptoStreamMode.Write);
            try
            {
                byte[] bEncrypt = Convert.FromBase64String(ciphertextBase64);
                cStream.Write(bEncrypt, 0, bEncrypt.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            finally
            {
                cStream.Close();
                mStream.Close();
            }
        }
        
        public string EncryptSymmetric(string plaintext)
        {
            
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, _symmetricProvider.CreateEncryptor(KEY, IV), CryptoStreamMode.Write);
                
            try
            {
                byte[] bPlainText = Encoding.UTF8.GetBytes(plaintext);
                cStream.Write(bPlainText, 0, bPlainText.Length);
                cStream.FlushFinalBlock();                
                return Convert.ToBase64String(mStream.ToArray());
            }
            finally
            {
                cStream.Close();
                mStream.Close();
            }
        }
    }
}
