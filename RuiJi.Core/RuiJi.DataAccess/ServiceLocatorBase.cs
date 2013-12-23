using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RuiJi.DataAccess
{
    public abstract class ServiceLocatorBase
    {
        bool _isInitiliazed = false;
        object _syncObj = new object();
        IDictionary<Type, object> _servicesDic = new Dictionary<Type, object>();
        IDictionary<Type, IServiceProvider> _providersDic = new Dictionary<Type, IServiceProvider>();

        protected ServiceLocatorBase()
        {
        }

        void Init()
        {
            var assembly = GetServiceLocatorAssembly();

            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                try
                {
                    var attrs = type.GetCustomAttributes(typeof(ServiceProviderBindingAttribute), false);

                    if (attrs != null && attrs.Length > 0)
                    {
                        var provider = Activator.CreateInstance(type) as IServiceProvider;

                        _providersDic[provider.GetServiceType()] = provider;
                    }
                }
                catch { }
            }
        }

        protected abstract Assembly GetServiceLocatorAssembly();

        public T GetSvc<T>() where T : class
        {
            CheckInitialized();

            object svc = null;
            Type type = typeof(T);

            if (!_servicesDic.TryGetValue(type, out svc))
            {
                lock (_syncObj)
                {
                    if (!_servicesDic.TryGetValue(type, out svc))
                    {
                        svc = CreateSvcCore<T>();
                        _servicesDic[type] = svc;
                    }
                }
            }

            return svc as T;
        }

        private void CheckInitialized()
        {
            if (!_isInitiliazed)
            {
                lock (_syncObj)
                {
                    if (!_isInitiliazed)
                    {
                        Init();
                        _isInitiliazed = true;
                    }
                }
            }
        }

        private T CreateSvcCore<T>() where T : class
        {
            IServiceProvider provider = null;

            if (!_providersDic.TryGetValue(typeof(T), out provider))
            {
                provider = null;
            }

            if (provider != null)
            {
                return provider.GetService() as T;
            }
            else
            {
                throw new MissingServiceException(typeof(T));
            }
        }
    }
}
