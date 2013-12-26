using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RuiJi.DataAccess.Models
{
    public partial class SystemUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsValid { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
