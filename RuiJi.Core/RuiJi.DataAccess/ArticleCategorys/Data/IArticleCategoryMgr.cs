using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ArticleCategorys.Data
{
    internal interface IArticleCategoryMgr 
    {
        int Add(ArticleCategory category);
        void Update(ArticleCategory category);
        ArticleCategory LoadById(int categoryId);
        List<ArticleCategory> LoadByParentId(int parentCategoryId);
        List<ArticleCategory> LoadAll();
        List<ArticleCategory> LoadAllShownOnHomePage();
    }
}
