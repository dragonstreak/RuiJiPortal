using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RuiJi.DataAccess.Models
{
    public partial class ErrorLog
    {
        public int ErrorId { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public string ExceptionType { get; set; }
        public System.DateTime InsertDate { get; set; }
        public Nullable<int> InnerErrorId { get; set; }
    }
}
