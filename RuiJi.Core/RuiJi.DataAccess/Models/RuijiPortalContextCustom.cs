using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RuiJi.DataAccess.Models
{
    public partial class RuijiPortalContext
    {
        public void CustomModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().MapToStoredProcedures(s => s.Insert(i => i.HasName("Article_Insert_p")));

        }
    }
}
