using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ArticleCategorys
{
    public interface IArticleCategoryCacheSvc
    {
        ReadOnlyCollection<ArticleCategory> LoadAllArticleCategory();
        List<ArticleCategory> LoadWithChildCategory(int categoryId);
    }
}
