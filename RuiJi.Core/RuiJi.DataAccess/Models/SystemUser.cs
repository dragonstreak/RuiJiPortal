using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RuiJi.DataAccess.Models
{
    public partial class SystemUser
    {
        public SystemUser()
        {
            this.UserRole_lnk = new List<UserRole_lnk>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsValid { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InsertBy { get; set; }
        public virtual ICollection<UserRole_lnk> UserRole_lnk { get; set; }
    }
}
