using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Enums;

namespace RuiJi.DataAccess.Articles
{
    public class LoadArticleByPagingParams
    {
        public int ArticleCategoryId { get; set; }

        public bool OnlyPublished { get; set; }

        public LanguageType Language { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
