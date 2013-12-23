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
            var svc = GetService();
            Article article = new Article();

            article.ArticleTypeId = 1;
            article.Author = "Tony";
            article.ContentDetail = "hello world";
            article.IsPublished = true;
            article.IsDeleted = false;
            article.PublishDate = new DateTime(2013, 12, 23);
            article.Title = "First Article";
            article.InsertBy = "Tony";
            article.UpdateBy = "Tony";

            svc.Add(article);
        }

        private IArticleSvc GetService()
        {
            return RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
        }
    }
}
