using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuiJi.DataAccess
{
    public abstract class ServiceProviderBase<T> : IServiceProvider
    {
        public Type GetServiceType()
        {
            return typeof(T);
        }

        public object GetService()
        {
            return GetServiceCore();
        }

        protected abstract T GetServiceCore();
    }
}
