using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Enums;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.Articles
{
    public interface IArticleSvc
    {
        int Add(Article article);
        void Update(Article article);
        void Delete(int articleId, string operatorName);
        Article LoadById(int articleId);
        void PhysicalDelete(int articleId);
        List<Article> LoadByArticleType(ArticleType articleType);
    }
}
