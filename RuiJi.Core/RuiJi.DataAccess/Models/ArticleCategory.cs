using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RuiJi.DataAccess.Models
{
    public partial class ArticleCategory
    {
        public int ArticleCategoryId { get; set; }
        public string Name { get; set; }
        public string UIResourceKey { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParentCategoryId { get; set; }
        public bool IsShowOnHomePage { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int HomePageDisplayOrder { get; set; }
        public string CNName { get; set; }
        public string ENName { get; set; }
    }
}
