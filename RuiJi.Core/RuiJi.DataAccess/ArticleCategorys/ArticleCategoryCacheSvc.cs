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


        public List<ArticleCategory> LoadWithAllChildrens(int categoryId)
        {
            var categoryList = ArticleCategoryListCache.Instance.ArticleCategorys;
            List<ArticleCategory> result = new List<ArticleCategory>();
            result.Add(categoryList.First(_ => _.ArticleCategoryId == categoryId));
            var childCategorys = categoryList.Where(_ => _.ParentCategoryId.HasValue
                                   && _.ParentCategoryId.Value == categoryId);
            if (childCategorys.Count() > 0)
            {
                childCategorys.ToList().ForEach(_ => result.Add(LoadWithAllChildrens(_.ArticleCategoryId).First()));
            }

            return result;
        }
    }
}
