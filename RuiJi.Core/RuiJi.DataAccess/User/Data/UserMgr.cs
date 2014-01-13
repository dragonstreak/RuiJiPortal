using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.User.Data
{
    internal class UserMgr : IUserMgr
    {
        public SystemUser LoadByName(string name)
        {
            using (var db = new RuijiPortalContext())
            {
                SystemUser user = db.SystemUsers.FirstOrDefault(_ => _.IsValid && _.UserName.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (user != null)
                {
                    return LoadById(user.UserId);
                }
                else
                {
                   return null;
                }
            }
        }

        public SystemUser LoadById(int userId)
        {
            using (var db = new RuijiPortalContext())
            {
                SystemUser user = db.SystemUsers.FirstOrDefault(_ => _.IsValid && _.UserId == userId);
                if (user != null)
                {
                    user.Roles = user.UserRole_lnk.Select(_ => _.Role.Code).ToList();
                }
                return user;
            }
        }

        public bool IsVaildUser(string name, string password)
        {
            using (var db = new RuijiPortalContext())
            {
                var user = db.SystemUsers.FirstOrDefault(_ => _.IsValid
                                                               && _.UserName.Equals(name, StringComparison.OrdinalIgnoreCase)
                                                               && _.Password.Equals(password, StringComparison.Ordinal));

                return user != null;
            }
        }

        public int Add(SystemUser user)
        {
            using (var db = new RuijiPortalContext())
            {
                db.SystemUsers.Add(user);
                db.SaveChanges();

                return user.UserId;
            }
        }
    }
}
