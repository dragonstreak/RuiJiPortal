using System;
using System.Collections.ObjectModel;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ArticleCategorys
{
    public interface IArticleCategoryCacheSvc
    {
        ReadOnlyCollection<ArticleCategory> LoadAllArticleCategory();
    }
}
