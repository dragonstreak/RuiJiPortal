using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuiJi.Internal.Web.Context;

namespace RuiJi.Internal.Context
{
    public class RuiJiContext : RuiJiContextBase<RuiJiContext>
    {
        public const string ContextCookieKey = "RuiJiCRemain";

        public RuiJiContext(int uid, string name)
        {
            userId = uid;
            userName = name;
            lastGenerateTime = DateTime.Now;
        }

        private int userId;
        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }

        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        private List<string> roles;
        public List<string> Roles
        {
            get
            {
                return roles;
            }
            set
            {
                roles = value;
            }
        }

        private DateTime lastGenerateTime;
        public DateTime LastGenerateTime
        {
            get
            {
                return lastGenerateTime;
            }
            set
            {
                lastGenerateTime = value;
            }
        }
    }
}