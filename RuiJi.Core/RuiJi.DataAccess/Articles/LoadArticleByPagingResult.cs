using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.Articles
{
    public class LoadArticleByPagingResult
    {
        public List<Article> ArticleList { get; set; }

        public int Total { get; set; }
    }
}
