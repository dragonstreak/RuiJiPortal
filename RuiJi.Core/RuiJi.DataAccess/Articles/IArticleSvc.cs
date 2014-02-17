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
        void Delete(int articleId, string operatorName);
        Article LoadById(int articleId);
        void PhysicalDelete(int articleId);
        List<Article> LoadByArticleCategoryId(int articleCategoryId);
        LoadArticleByPagingResult LoadByArticleCategoryIdWithPaging(LoadArticleByPagingParams param);
        List<Article> LoadArticleForManage(int categoryId, string title, bool? published);
    }
}
