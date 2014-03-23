using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Enums;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.DataAccess.Articles.Data;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.Articles
{
    public class ArticleSvc : IArticleSvc
    {
        private IArticleMgr _mgr;
        private IArticleCategoryCacheSvc _articleCategoryCacheSvc;

        internal ArticleSvc(IArticleMgr mgr, IArticleCategoryCacheSvc articleCategoryCacheSvc)
        {
            _mgr = mgr;
            _articleCategoryCacheSvc = articleCategoryCacheSvc;
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

        public List<Article> LoadByArticleCategoryId(int articleCategoryId, LanguageType language, bool onlyPublished)
        {
            List<Article> result = new List<Article>();
            var categoryList = _articleCategoryCacheSvc.LoadWithAllChildrens(articleCategoryId);
            foreach (var category in categoryList)
            {
                result.AddRange(_mgr.LoadByArticleCategoryId(category.ArticleCategoryId));
            }
            if (onlyPublished)
            {
                result.RemoveAll(_ => !_.IsPublished);
            }
            if (language != LanguageType.All)
            {
                result.RemoveAll(_ => !_.LanguageType.HasValue || _.LanguageType != (int)language);
            }

            return result.OrderByDescending(_ => _.PublishDate).ToList();

        }

        public LoadArticleByPagingResult LoadByArticleCategoryIdWithPaging(LoadArticleByPagingParams param)
        {
            var totalList = LoadByArticleCategoryId(param.ArticleCategoryId, param.Language, param.OnlyPublished);
            var result = new LoadArticleByPagingResult();
            result.Total = totalList.Count;
            result.ArticleList = totalList.Skip((param.PageIndex - 1) * param.PageSize)
                                          .Take(param.PageSize).ToList();
            return result;
        }


        public List<Article> LoadArticleForManage(int categoryId, string title, LanguageType language, bool? published)
        {
            var articleList = LoadByArticleCategoryId(categoryId, language, false);
            var result = from a in articleList
                         where (title == null || a.Title.Contains(title))
                               && (!published.HasValue || published.Value == a.IsPublished)
                         select a;

            return result.OrderByDescending(_ => _.InsertDate).ToList();
        }

    }
}
