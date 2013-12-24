using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuiJi.Common
{
    public class RuiJiExceptionBase : Exception
    {
        public RuiJiExceptionBase(string message) : base(message)
        {            
        }

        public RuiJiExceptionBase(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}
