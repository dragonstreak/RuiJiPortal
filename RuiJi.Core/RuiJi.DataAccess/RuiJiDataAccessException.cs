using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.Common;

namespace RuiJi.DataAccess
{
    public class RuiJiDataAccessException : RuiJiExceptionBase
    {
        public RuiJiDataAccessException(string message) : base(message)
        {            
        }

        public RuiJiDataAccessException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
