using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuiJi.Internal.Web.Context
{
    public interface IServerContext
    {
        string ServerName { get; set; }
    }
}