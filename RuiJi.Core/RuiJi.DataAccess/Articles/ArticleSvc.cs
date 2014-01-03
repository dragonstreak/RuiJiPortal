using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.DataAccess.Articles.Data;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.Articles
{
    public class ArticleSvc : IArticleSvc
    {
        private IArticleMgr _mgr;
        private IArticleCategorySvc _articleCategorySvc;

        internal ArticleSvc(IArticleMgr mgr, IArticleCategorySvc articleCategorySvc)
        {
            _mgr = mgr;
            _articleCategorySvc = articleCategorySvc;
        }

        public int Add(Article article)
        {
            return _mgr.Add(article);
        }

        public void Update(Article article)
        {
           _mgr.Update(article);
        }

        public void Delete(int articleId, string operatorName)
        {
            var article = LoadById(articleId);
            article.IsDeleted = true;
            article.UpdateBy = operatorName;
            _mgr.Update(article);
        }

        public void PhysicalDelete(int articleId)
        {
            _mgr.PhysicalDelete(articleId);
        }

        public Article LoadById(int articleId)
        {
            var article = _mgr.LoadById(articleId);
            if (article == null)
            {
                throw new RuiJiDataAccessException("The Article not existing!");
            }
            else
            {
                return article;
            }
        }

        public List<Article> LoadByArticleCategoryId(int articleCategoryId)
        {
            List<Article> result = new List<Article>();
            var categoryList = LoadArticleCategoryWithChild(articleCategoryId);
            foreach (var category in categoryList)
            {
                result.AddRange(_mgr.LoadByArticleCategoryId(category.ArticleCategoryId));
            }

            return result;

        }

        public LoadArticleByPagingResult LoadByArticleCategoryIdWithPaging(LoadArticleByPagingParams param)
        {
            var totalList = LoadByArticleCategoryId(param.ArticleCategoryId);
            var result = new LoadArticleByPagingResult();
            result.Total = totalList.Count;
            result.ArticleList = totalList.OrderByDescending(_ => _.PublishDate)
                                          .Skip((param.PageIndex - 1) * param.PageSize)
                                          .Take(param.PageSize).ToList();
            return result;
        }

        private List<ArticleCategory> LoadArticleCategoryWithChild(int articleCategoryId)
        {
            List<ArticleCategory> result = new List<ArticleCategory>();

            var category =_articleCategorySvc.LoadById(articleCategoryId);
            if (category != null)
            {
                result.Add(category);
            }

            var childCategoryList = _articleCategorySvc.LoadByParentId(articleCategoryId);
            foreach (var childCategory in childCategoryList)
            {
                result.AddRange(LoadArticleCategoryWithChild(childCategory.ArticleCategoryId));
            }

            return result;
        }

    }
}
