using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ArticleCategorys.Data
{
    internal class ArticleCategoryMgr : IArticleCategoryMgr
    {
        internal ArticleCategoryMgr()
        {
        }

        public int Add(ArticleCategory category)
        {
            using (var db = new RuijiPortalContext())
            {
                category.CreateDate = DateTime.UtcNow;
                category.UpdateDate = DateTime.UtcNow;

                db.ArticleCategories.Add(category);
                db.SaveChanges();

                return category.ArticleCategoryId;
            }
        }

        public void Update(ArticleCategory category)
        {
            using (var db = new RuijiPortalContext())
            {
                category.UpdateDate = DateTime.UtcNow;

                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public ArticleCategory LoadById(int categoryId)
        {
            using (var db = new RuijiPortalContext())
            {
                var category = db.ArticleCategories.Find(categoryId);
                if (category != null && !category.IsDeleted)
                {
                    return category;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<ArticleCategory> LoadByParentId(int parentCategoryId)
        {            
            using (var db = new RuijiPortalContext())
            {
                var query = from c in db.ArticleCategories
                            where c.ParentCategoryId.HasValue
                                  && c.ParentCategoryId.Value == parentCategoryId
                                  && !c.IsDeleted
                            orderby c.HomePageDisplayOrder
                            select c;
                return query.ToList();
            }
        }

        public List<ArticleCategory> LoadAll()
        {
            using (var db = new RuijiPortalContext())
            {
                return db.ArticleCategories.Where(_ => !_.IsDeleted).ToList();
            }
        }
        
        public List<ArticleCategory> LoadAllShownOnHomePage() {
			using (var db = new RuijiPortalContext()) {
				var categories = db.ArticleCategories.Where(t => !t.IsDeleted && t.IsShowOnHomePage).OrderBy(t => t.HomePageDisplayOrder);
				return categories.ToList();
			}
		}
    }
}
