using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuiJi.DataAccess;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.DataAccess.Models;
using RuiJi.Internal.Models;

namespace RuiJi.Internal.Extensions
{
    public static class ArticleCategoryExtension
    {
        public static ArticleCategoryItemModel ToItemModel(this ArticleCategory dbModel)
        {
            if (dbModel == null)
            {
                throw new ArgumentNullException("ArticleCategory DB Model is null!");
            }

            return new ArticleCategoryItemModel()
            {
                ArticleCategoryId = dbModel.ArticleCategoryId,
                Name = dbModel.Name,
                Description = dbModel.Description,
                HomePageDisplayOrder = dbModel.HomePageDisplayOrder,
                IsShowOnHomePage = dbModel.IsShowOnHomePage,
                ParentCategoryId = dbModel.ParentCategoryId,
                UIResourceKey = dbModel.UIResourceKey,
                CNName = dbModel.CNName,
                ENName = dbModel.ENName
            };
        }


        public static List<ArticleCategoryItemModel> GetAllArticleCategory()
        {
            var categoryList = ArticleCategoryCacheSvc.LoadAllArticleCategory();
            return categoryList.Select(_ => _.ToItemModel()).ToList();
        }

        private static IArticleCategoryCacheSvc _articleCategoryCacheSvc;
        public static IArticleCategoryCacheSvc ArticleCategoryCacheSvc
        {
            get
            {
                if (_articleCategoryCacheSvc == null)
                {
                    _articleCategoryCacheSvc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategoryCacheSvc>();
                }
                return _articleCategoryCacheSvc;
            }
        }
    }
}