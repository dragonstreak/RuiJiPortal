using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Articles.Data;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.Articles
{
    public class ArticleSvc : IArticleSvc
    {
        private IArticleMgr _mgr;

        internal ArticleSvc(IArticleMgr mgr)
        {
            _mgr = mgr;
        }

        public int Add(Article article)
        {
            return _mgr.Add(article);
        }

        public void Update(Article article)
        {
           _mgr.Update(article);
        }

        public void Delete(int articleId, string operatorName)
        {
            var article = LoadById(articleId);
            article.IsDeleted = true;
            article.UpdateBy = operatorName;
            _mgr.Update(article);
        }

        public void PhysicalDelete(int articleId)
        {
            _mgr.PhysicalDelete(articleId);
        }

        public Article LoadById(int articleId)
        {
            var article = _mgr.LoadById(articleId);
            if (article == null)
            {
                throw new RuiJiDataAccessException("The Article not existing!");
            }
            else
            {
                return article;
            }
        }

    }
}
