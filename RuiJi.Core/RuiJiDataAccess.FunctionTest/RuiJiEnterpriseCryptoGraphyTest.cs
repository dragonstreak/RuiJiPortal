using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuiJiDataAccess.FunctionTest
{
    [TestClass]
    public class RuiJiEnterpriseCryptoGraphyTest
    {
        [TestMethod]
        public void EncryptSymmetricStringTest()
        {
            string originString = "111111";
            var encryptString = RuiJiEnterpriseCryptoGraphy.Instance.EncryptSymmetric(originString);
            Assert.AreEqual(true, encryptString != originString);
        }

        [TestMethod]
        public void DecryptSymmetricStringTest()
        {
            string originString = "111111";
            var encryptString = RuiJiEnterpriseCryptoGraphy.Instance.EncryptSymmetric(originString);
            var decryptString = RuiJiEnterpriseCryptoGraphy.Instance.DecryptSymmetric(encryptString);
            Assert.AreEqual(true, decryptString == originString);
        }
    }
}
