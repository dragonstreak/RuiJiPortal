﻿using System;
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

		public List<ArticleCategory> LoadAllShownOnHomePage() {
			List<ArticleCategory> result = new List<ArticleCategory>();

			return _mgr.LoadAllShownOnHomePage();
		}
    }
}
