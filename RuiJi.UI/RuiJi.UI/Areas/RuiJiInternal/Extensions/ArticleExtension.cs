using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Enums;
using RuiJi.DataAccess;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.DataAccess.Models;
using RuiJi.Internal.Models;

namespace RuiJi.Internal.Extensions
{
    public static class ArticleExtension
    {

        private static IArticleCategoryCacheSvc _articleCategoryCacheSvc;
        static ArticleExtension()
        {
            _articleCategoryCacheSvc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategoryCacheSvc>();
        }

        public static ArticleItemModel ToItemModel(this Article dbModel)
        {
            if (dbModel == null)
            {
                throw new ArgumentNullException("Article DB Model is null");
            }

            return new ArticleItemModel()
            {
                ArticleCategoryId = dbModel.ArticleCategoryId,
                ArticleId = dbModel.ArticleId,
                Author = dbModel.Author,
                ContentDetail = dbModel.ContentDetail,
                InsertBy = dbModel.InsertBy,
                InsertDate = dbModel.InsertDate,
                IsDeleted = dbModel.IsDeleted,
                IsPublished = dbModel.IsPublished,
                PublishDate = dbModel.PublishDate,
                Summary = dbModel.Summary,
                Title = dbModel.Title,
                UpdateBy = dbModel.UpdateBy,
                UpdateDate = dbModel.UpdateDate,
                Language = (LanguageType)dbModel.LanguageType.Value,
                ArticleCategoryName = _articleCategoryCacheSvc.LoadAllArticleCategory().First( _ => _.ArticleCategoryId == dbModel.ArticleCategoryId).Description
            };
        }

        public static List<ArticleItemModel> ToListModel(this List<Article> dbModel)
        {
            if (dbModel == null)
            {
                return new List<ArticleItemModel>();
            }

            return dbModel.Select(_ => _.ToItemModel()).ToList();
        }

    }
}