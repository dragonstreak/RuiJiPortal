using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.User
{
    public interface IUserSvc
    {
        SystemUser LoadByName(string name);
        SystemUser LoadById(int userId);
        bool IsVaildUser(string name, string password);
        int Add(SystemUser user);
    }
}
