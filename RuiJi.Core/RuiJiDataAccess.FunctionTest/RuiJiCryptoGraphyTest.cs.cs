using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuiJiDataAccess.FunctionTest
{
    [TestClass]
    public class RuiJiCryptoGraphyTest
    {
        [TestMethod]
        public void CreateHashTest()
        {
           string sPlain = "1";
           var sHashed = RuiJiCryptoGraphy.Instance.CreateHash(sPlain);
           Assert.AreEqual(true, sHashed != sPlain);
        }

        [TestMethod]
        public void CompareHashTest()
        {
            string sPlain = "1";
            string sPlain2 = "2";
            string sHashed = "F0fNsge6CP1x3JXpJpYZ8A==";
            var result = RuiJiCryptoGraphy.Instance.CompareHash(sPlain, sHashed);
            Assert.AreEqual(true, result);
            var result2 = RuiJiCryptoGraphy.Instance.CompareHash(sPlain2, sHashed);
            Assert.AreEqual(false, result2);

        }

        [TestMethod]
        public void EncryptSymmetricTest()
        {
            string sPlain = "1";
            var sEncrypt = RuiJiCryptoGraphy.Instance.EncryptSymmetric(sPlain);
            Assert.AreEqual(true, sEncrypt != sPlain);
        }

        [TestMethod]
        public void DecryptSymmetricTest()
        {
            string sPlain = "1";
            var sEncrypt = RuiJiCryptoGraphy.Instance.EncryptSymmetric(sPlain);
            var sDecrypt = RuiJiCryptoGraphy.Instance.DecryptSymmetric(sEncrypt);
            Assert.AreEqual(true, sDecrypt == sPlain);
        }
    }
}
