using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RuiJi.Internal.Web.Context
{
    public class RuiJiContextBase<TContext> : IServerContext where TContext : class, IServerContext
    {
        private string _serverName;

        public RuiJiContextBase()
        {
            _serverName = Environment.MachineName;
        }

        public RuiJiContextBase(string serverName)
        {
            _serverName = serverName;
        }

        public string ServerName
        {
            get
            {
                return _serverName;
            }
            set
            {
                _serverName = value;
            }
        }

        public static TContext Current
        {
            get
            {
                return ContextManager<TContext>.GetContext(HttpContext.Current);
            }
            set
            {
                ContextManager<TContext>.SetContext(value, HttpContext.Current);
            }
        }


    }
}
