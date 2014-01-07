using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.ArticleCategorys.Cache;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ArticleCategorys
{
    public class ArticleCategoryCacheSvc : IArticleCategoryCacheSvc
    {
        public ReadOnlyCollection<ArticleCategory> LoadAllArticleCategory()
        {
            return ArticleCategoryListCache.Instance.ArticleCategorys;
        }
    }
}
