using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RuiJi.DataAccess.Models
{
    public partial class ArticleType_Lkp
    {
        public ArticleType_Lkp()
        {
            this.Articles = new List<Article>();
        }

        public int ArticleTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
