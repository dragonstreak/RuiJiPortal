using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;

namespace Common
{
    public class RuiJiEnterpriseCryptoGraphy
    {
        public static readonly RuiJiEnterpriseCryptoGraphy Instance = new RuiJiEnterpriseCryptoGraphy();

        private string RuiJiHashProvider = "RuiJiHashProvider";
        private string RuiJiSymmerticProvider = "RuiJiSymmetricCryptoServiceProvider";

        private CryptographyManager cryptoManager;

        private RuiJiEnterpriseCryptoGraphy()
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
