using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;
using RuiJi.DataAccess.User.Data;

namespace RuiJi.DataAccess.User
{
    public class UserSvc : IUserSvc
    {
        private IUserMgr _mgr;

        internal UserSvc(IUserMgr mgr)
        {
            _mgr = mgr;
        }

        public SystemUser LoadByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("User name can not be empty");
            }

            return _mgr.LoadByName(name);
        }

        public SystemUser LoadById(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentNullException("User Id must big than zero");
            }

            return _mgr.LoadById(userId);
        }

        public bool IsVaildUser(string name, string encryptedPassword)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("User name can not be empty");
            }

            return _mgr.IsVaildUser(name, encryptedPassword);
        }

        public int Add(SystemUser user)
        {
            if (user.UserId != 0)
            {
                throw new ArgumentException("Invalid UserId for add new user!");
            }

            return _mgr.Add(user);
        }
    }
}
