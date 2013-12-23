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
            mgr = _mgr;
        }

        public int Add(Article article)
        {
            return _mgr.Add(article);
        }

        public void Update(Article article)
        {
            _mgr.Update(article);
        }

        public void Delete(int articleId)
        {
            _mgr.Delete(articleId);
        }

        public Article LoadById(int articleId)
        {
            return _mgr.LoadById(articleId);
        }

    }
}
