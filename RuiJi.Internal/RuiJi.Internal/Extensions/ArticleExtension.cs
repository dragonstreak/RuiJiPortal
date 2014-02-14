using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuiJi.DataAccess.Models;
using RuiJi.Internal.Models;

namespace RuiJi.Internal.Extensions
{
    public static class ArticleExtension
    {
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
                UpdateDate = dbModel.UpdateDate
            };
        }
    }
}