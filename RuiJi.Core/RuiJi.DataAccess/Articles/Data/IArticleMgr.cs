using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.Articles.Data
{
    internal interface IArticleMgr
    {
        int Add(Article article);
        void Update(Article article);
        void PhysicalDelete(int articleId);
        Article LoadById(int articleId);
        List<Article> LoadByArticleCategoryId(int articleCategoryId);
    }
}
