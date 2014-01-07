using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuiJi.DataAccess;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.DataAccess.Models;

namespace RuiJiDataAccess.FunctionTest
{
    [TestClass]
    public class ArticleCategoryTest
    {
        [TestMethod]
        public void AddTest()
        {
            var category = GetArticleCategory();
            ArticleCategorySvc.Add(category);
            Assert.AreEqual(true, category.ArticleCategoryId > 0);
        }

        [TestMethod]
        public void ArticleCategoryCacheTest()
        {
            var categorys = ArticleCategoryCacheSvc.LoadAllArticleCategory();
            Assert.AreEqual(true, categorys != null);
            categorys = ArticleCategoryCacheSvc.LoadAllArticleCategory();
            Assert.AreEqual(true, categorys.Count > 0);
        }

        private ArticleCategory GetArticleCategory()
        {
            ArticleCategory category = new ArticleCategory()
            {
                Name = "RongYuZiZhi",
                Description = "荣誉资质",
                ParentCategoryId = 8,
                CreateBy = "Tony.Xu",
                UpdateBy = "Tony.Xu",
                IsDeleted = false
            };

            return category;

        }

        private IArticleCategorySvc _articleCategorySvc;
        private IArticleCategorySvc ArticleCategorySvc
        {
            get
            {
                if (_articleCategorySvc == null)
                {
                    _articleCategorySvc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategorySvc>();
                }

                return _articleCategorySvc;
            }
        }

        private IArticleCategoryCacheSvc _articleCategoryCacheSvc;
        private IArticleCategoryCacheSvc ArticleCategoryCacheSvc
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
