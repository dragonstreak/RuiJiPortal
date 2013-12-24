using System;
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

            article.ArticleTypeId = 1;
            article.Author = "Tony";
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
