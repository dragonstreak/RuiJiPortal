﻿using System;
using Common.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuiJi.DataAccess;
using RuiJi.DataAccess.Articles;
using RuiJi.DataAccess.Models;

namespace RuiJiDataAccess.FunctionTest
{
    [TestClass]
    public class ArticleTest
    {
        [TestMethod]
        public void AddTest()
        {
            Article article = GetArticle();
            article.Author = "AddTest1";
            ArticleSvc.Add(article);

            Assert.AreEqual(true, article.ArticleId > 0);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Article article = GetArticle();
            article.Author = "UpdateTest1";
            ArticleSvc.Add(article);

            article.Author = "UpdateTest2";
            ArticleSvc.Update(article);

            article = ArticleSvc.LoadById(article.ArticleId);            
            Assert.AreEqual("UpdateTest2", article.Author);

            article.Author = "UpdateTest3";
            ArticleSvc.Update(article);

            article = ArticleSvc.LoadById(article.ArticleId);
            Assert.AreEqual("UpdateTest3", article.Author);

        }

        [TestMethod]
        [ExpectedException(typeof(RuiJiDataAccessException))]
        public void DeleteTest()
        {
            Article article = GetArticle();
            article.Author = "DeleteTest1";
            ArticleSvc.Add(article);
            Assert.AreEqual(false, article.IsDeleted);
            ArticleSvc.Delete(article.ArticleId, "DeleteTest2");
            article = ArticleSvc.LoadById(article.ArticleId);
            Assert.AreEqual(null, article);
        }

        [TestMethod]
        public void LoadByArticleTypeTest()
        {
            var articleList = ArticleSvc.LoadByArticleCategoryId(1, LanguageType.All,false);
            Assert.AreEqual(true, articleList.Count > 0);
        }

        [TestMethod]
        public void LoadByArticleCategoryIdWithPagingTest()
        {
            var param = new LoadArticleByPagingParams()
            {
                ArticleCategoryId = 1
             ,  PageIndex = 2
             ,  PageSize = 2
            };

            var result = ArticleSvc.LoadByArticleCategoryIdWithPaging(param);
            Assert.AreEqual(2, result.ArticleList.Count);
            param.PageIndex = 100;
            param.PageSize = 1000;
            result = ArticleSvc.LoadByArticleCategoryIdWithPaging(param);
            Assert.AreEqual(0, result.ArticleList.Count);
        }

        private IArticleSvc _articleSvc;
        private IArticleSvc ArticleSvc
        {
            get
            {
                if (_articleSvc == null)
                {
                    _articleSvc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
                }
                return _articleSvc;
            }
        }

        private Article GetArticle()
        {
            Article article = new Article();

            Random r = new Random();

            article.ArticleCategoryId = 1;
            article.Author = "Tony";
            article.Summary = "summary";
            article.ContentDetail = r.Next(1,10000).ToString();
            article.IsPublished = true;
            article.IsDeleted = false;
            article.PublishDate = new DateTime(2013, 12, 23);
            article.Title = "Test Article";
            article.InsertBy = "Tony";
            article.UpdateBy = "Tony";

            return article;
        }
    }
}
