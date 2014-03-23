using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ArticleCategorys
{
    public interface IArticleCategorySvc
    {
        int Add(ArticleCategory category);
        void Update(ArticleCategory category);
        void Delete(int categoryId, string operatorName);
        ArticleCategory LoadById(int categoryId);
        List<ArticleCategory> LoadByParentId(int parentCategoryId);
        List<ArticleCategory> LoadWithAllChildrens(int categoryId);
        List<ArticleCategory> LoadArticleCategoryPath(int childArticleCategoryId);
        List<ArticleCategory> LoadAll();
    }
}
