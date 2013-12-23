using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.Articles
{
    public interface IArticleSvc
    {
        int Add(Article article);
        void Update(Article article);
        void Delete(int articleId);
        Article LoadById(int articleId);
    }
}
