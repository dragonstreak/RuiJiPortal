using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RuiJi.DataAccess.Models
{
    public partial class SystemUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
