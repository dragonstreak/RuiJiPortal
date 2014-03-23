using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.ArticleCategorys.Data;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ArticleCategorys
{
    public class ArticleCategorySvc : IArticleCategorySvc
    {
        private IArticleCategoryMgr _mgr;

        internal ArticleCategorySvc(IArticleCategoryMgr mgr)
        {
            this._mgr = mgr;
        }

        public int Add(ArticleCategory category)
        {
            return _mgr.Add(category);
        }

        public void Update(ArticleCategory category)
        {
            _mgr.Update(category);
        }

        public void Delete(int categoryId, string operatorName)
        {
            var category = _mgr.LoadById(categoryId);
            if (category != null)
            {
                category.IsDeleted = true;
                category.UpdateBy = operatorName;
                _mgr.Update(category);
            }
        }

        public ArticleCategory LoadById(int categoryId)
        {
            return _mgr.LoadById(categoryId);
        }

        public List<ArticleCategory> LoadByParentId(int parentCategoryId)
        {
            return _mgr.LoadByParentId(parentCategoryId);
        }

        public List<ArticleCategory> LoadWithAllChildrens(int categoryId)
        {
            List<ArticleCategory> result = new List<ArticleCategory>();

            var category = _mgr.LoadById(categoryId);
            if (category != null)
            {
                result.Add(category);
            }

            var childCategoryList = _mgr.LoadByParentId(categoryId);
            foreach (var childCategory in childCategoryList)
            {
                result.AddRange(LoadWithAllChildrens(childCategory.ArticleCategoryId));
            }

            return result;
        }

        /// <summary>
        /// Returns the sequences of all parent categories from top to down.
        /// </summary>
        /// <param name="childArticleCategoryId"></param>
        /// <returns></returns>
        public List<ArticleCategory> LoadArticleCategoryPath(int childArticleCategoryId)
        {
            List<ArticleCategory> path = new List<ArticleCategory>();

            var category = _mgr.LoadById(childArticleCategoryId);

            if (category == null)
            {
                return path;
            }
            else
            {
                path.Add(category);
            }

            // Anyway, no need to write test cases, hereby not to do it by recursing.
            ArticleCategory currentCategory = category;
            while (currentCategory.ParentCategoryId.HasValue)
            {
                if (currentCategory.ParentCategoryId.GetValueOrDefault() <= 0)
                {
                    break;
                }

                var parentCategory = _mgr.LoadById(currentCategory.ParentCategoryId.GetValueOrDefault());

                if (parentCategory != null)
                {
                    path.Add(parentCategory);
                    currentCategory = parentCategory;
                }
                else
                {
                    break;
                }
            }

            path.Reverse();

            return path;
        }

        public List<ArticleCategory> LoadAll()
        {
            return _mgr.LoadAll();
        }
    }
}
