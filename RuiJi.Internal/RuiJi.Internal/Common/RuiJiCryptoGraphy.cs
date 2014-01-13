using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;

namespace RuiJi.Internal.Common
{
    public class RuiJiCryptoGraphy
    {
        public static readonly RuiJiCryptoGraphy Instance = new RuiJiCryptoGraphy();

        private string RuiJiHashProvider = "RuiJiHashProvider";
        private string RuiJiSymmerticProvider = "RuiJiSymmetricCryptoServiceProvider";

        private CryptographyManager cryptoManager;

        private RuiJiCryptoGraphy()
        {
            cryptoManager = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
        }

        public bool CompareHash(byte[] plaintext, byte[] hashedText)
        {
            return cryptoManager.CompareHash(RuiJiHashProvider, plaintext, hashedText);
        }

        public bool CompareHash(string plaintext, string hashedText)
        {
            return cryptoManager.CompareHash(RuiJiHashProvider, plaintext, hashedText);
        }

        public byte[] CreateHash(byte[] plaintext)
        {
            return cryptoManager.CreateHash(RuiJiHashProvider, plaintext);
        }

        public string CreateHash(string plaintext)
        {
            return cryptoManager.CreateHash(RuiJiHashProvider, plaintext);
        }

        public byte[] DecryptSymmetric(byte[] ciphertext)
        {
            return cryptoManager.DecryptSymmetric(RuiJiSymmerticProvider, ciphertext);
        }

        public string DecryptSymmetric(string ciphertextBase64)
        {
            return cryptoManager.DecryptSymmetric(RuiJiSymmerticProvider, ciphertextBase64);
        }

        public byte[] EncryptSymmetric(byte[] plaintext)
        {
            return cryptoManager.EncryptSymmetric(RuiJiSymmerticProvider, plaintext);
        }

        public string EncryptSymmetric(string plaintext)
        {
            return cryptoManager.EncryptSymmetric(RuiJiSymmerticProvider, plaintext);
        }
    }
}