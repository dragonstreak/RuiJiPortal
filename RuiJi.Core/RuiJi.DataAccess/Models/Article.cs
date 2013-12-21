using System;
using System.Collections.Generic;

namespace RuiJi.DataAccess.Models
{
    public partial class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string ContentDetail { get; set; }
        public int ArticleTypeId { get; set; }
        public string Author { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string InsertBy { get; set; }
        public byte[] TIMESTAMP { get; set; }
        public virtual ArticleType_Lkp ArticleType_Lkp { get; set; }
    }
}
