using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Enums;
using RuiJi.Internal.Extensions;

namespace RuiJi.Internal.Models
{
    public class ArticleItemModel : BaseModel
    {
        public ArticleItemModel()
        {
            ArticleCategoryList = ArticleCategoryExtension.GetAllArticleCategory();
        }

        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }

        //[AllowHtml]
        public string ContentDetail { get; set; }
        public int ArticleCategoryId { get; set; }
        public string Author { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string InsertBy { get; set; }

        public string ArticleCategoryName { get; set; }

        public List<ArticleCategoryItemModel> ArticleCategoryList { get; set; }
        public LanguageType Language { get; set; }
        public int DisplayOrder { get; set; }
    }
}