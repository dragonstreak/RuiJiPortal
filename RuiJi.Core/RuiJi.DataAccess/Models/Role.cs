using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RuiJi.DataAccess.Models
{
    public partial class Role
    {
        public Role()
        {
            this.UserRole_lnk = new List<UserRole_lnk>();
        }

        public int RoleId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InsertBy { get; set; }
        public virtual ICollection<UserRole_lnk> UserRole_lnk { get; set; }
    }
}
