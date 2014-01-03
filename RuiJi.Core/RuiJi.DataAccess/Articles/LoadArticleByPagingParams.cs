using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuiJi.DataAccess.Articles
{
    public class LoadArticleByPagingParams
    {
        public int ArticleCategoryId { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
