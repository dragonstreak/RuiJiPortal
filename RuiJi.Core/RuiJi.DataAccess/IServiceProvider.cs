using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuiJi.DataAccess
{
    public interface IServiceProvider
    {
        Type GetServiceType();
        object GetService();
    }
}
