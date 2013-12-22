using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
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
                db.SaveChanges();
            }
        }

        public void Delete(int articleId)
        {
            using (var db = new RuijiPortalContext())
            {
                Article article = db.Articles.Find(articleId);
                db.Articles.Remove(article);
                db.SaveChanges();
            }
        }

    }
}
