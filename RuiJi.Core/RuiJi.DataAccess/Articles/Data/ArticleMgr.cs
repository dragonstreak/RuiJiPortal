using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Common.Enums;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.Articles.Data
{
    class ArticleMgr : IArticleMgr
    {
        internal ArticleMgr()
        {
        }

        public int Add(Article article)
        {
            using (var db = new RuijiPortalContext())
            {
                db.Articles.Add(article);
                db.SaveChanges();

                return article.ArticleId;
            }
        }

        public void Update(Article article)
        {
            using (var db = new RuijiPortalContext())
            {
                db.Entry(article).State = EntityState.Modified;
                var updateCount = db.SaveChanges();
            }
        }

        public void PhysicalDelete(int articleId)
        {
            using (var db = new RuijiPortalContext())
            {
                Article article = db.Articles.Find(articleId);
                db.Articles.Remove(article);
                db.SaveChanges();
            }
        }

        public Article LoadById(int articleId)
        {
            using (var db = new RuijiPortalContext())
            {
                Article article = db.Articles.Find(articleId);
                if (article != null && !article.IsDeleted)
                {
                    return article;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<Article> LoadByArticleType(ArticleType articleType)
        {
            using (var db = new RuijiPortalContext())
            {
                List<Article> result;
                var queryResult = db.Database.SqlQuery<Article>(string.Format("select * from dbo.Article where IsDeleted = 0 and ArticleTypeId = {0}", (int)articleType));
                result = queryResult.ToList<Article>();
                return result;
            }
        }

    }
}
