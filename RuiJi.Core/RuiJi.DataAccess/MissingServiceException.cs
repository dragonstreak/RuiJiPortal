using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace RuiJi.DataAccess
{
    [ExcludeFromCodeCoverage]
    public class MissingServiceException : InvalidOperationException
    {
        public MissingServiceException(
            Type serviceType
            )
        {
            ServiceType = serviceType;
        }

        public override string Message
        {
            get
            {
                return string.Format("Can't find service type {0}", ServiceType);
            }
        }

        public Type ServiceType
        {
            get;
            private set;
        }
    }
}
