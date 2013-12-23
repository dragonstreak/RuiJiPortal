using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RuiJi.DataAccess
{
    public sealed class RuiJiPortalServiceLocator : ServiceLocatorBase
    {
        public static RuiJiPortalServiceLocator Instance = new RuiJiPortalServiceLocator();

        protected override Assembly GetServiceLocatorAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}
