using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuiJi.Internal.Models
{
    public class ArticleCategoryItemModel : BaseModel
    {
        public int ArticleCategoryId { get; set; }
        public string Name { get; set; }
        public string UIResourceKey { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParentCategoryId { get; set; }
        public bool IsShowOnHomePage { get; set; }
        public int HomePageDisplayOrder { get; set; }
    }
}