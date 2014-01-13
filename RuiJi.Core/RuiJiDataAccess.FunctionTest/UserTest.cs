using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuiJi.DataAccess;
using RuiJi.DataAccess.Models;
using RuiJi.DataAccess.User;

namespace RuiJiDataAccess.FunctionTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void LoadByNameTest()
        {
            SystemUser user = UserSvc.LoadByName("Tony.Xu");
            Assert.AreNotEqual(null, user);

            Assert.AreNotEqual(null, user.Roles);
            
        }

        [TestMethod]
        public void AddTest()
        {
            SystemUser user = GetUser();
            UserSvc.Add(user);

            Assert.AreNotEqual(0, user.UserId);

            user = UserSvc.LoadById(user.UserId);

            Assert.AreEqual(0, user.Roles.Count);
        }

        private SystemUser GetUser()
        {
            Random r = new Random();

            SystemUser user = new SystemUser()
                             {
                                 UserName = "Test" + r.Next(0, 100000).ToString(),
                                 Password = "1",
                                 IsValid = true,
                                 InsertBy = "FunctionTest",
                                 InsertDate = DateTime.UtcNow
                             };

            return user;
        }

        private IUserSvc _userSvc;
        private IUserSvc UserSvc
        {
            get
            {
                if (_userSvc == null)
                {
                    _userSvc = RuiJiPortalServiceLocator.Instance.GetSvc<IUserSvc>();
                }

                return _userSvc;
            }
        }

    }
}
