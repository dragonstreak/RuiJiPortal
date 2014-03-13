using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuiJi.Internal.Models
{
    public class SimpleDDLItemModel<TName,TValue>
    {
        public TName Name { get; set; }
        public TValue Value { get; set; }
    }
}