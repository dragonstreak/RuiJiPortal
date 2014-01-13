using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.User.Data;

namespace RuiJi.DataAccess.User
{
    [ServiceProviderBinding]
    internal class UserSvcProvider : ServiceProviderBase<IUserSvc>
    {
        protected override IUserSvc GetServiceCore()
        {
            IUserMgr mgr = CreateUserMgr();
            return new UserSvc(mgr);
        }

        private IUserMgr CreateUserMgr()
        {
            return new UserMgr();
        }
    }
}
