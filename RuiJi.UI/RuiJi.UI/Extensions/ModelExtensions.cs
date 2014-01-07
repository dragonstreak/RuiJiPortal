using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuiJi.DataAccess.Models;
using RuiJi.UI.Models;

namespace RuiJi.UI.Extensions {
	public static class ModelExtensions {
		public static ArticleModel ToModel(this Article article) {
			ArticleModel model = new ArticleModel() {
				Abstract = article.Summary,
				ArticleId = article.ArticleId,
				Author = article.Author,
				ContentDetail = article.ContentDetail,
				PublishDate = article.PublishDate.GetValueOrDefault(),
				Title = article.Title
			};

			return model;
		}

		public static List<ArticleModel> ToModels(this IEnumerable<Article> articles) {
			List<ArticleModel> models = null;

			models = articles.Select(t => t.ToModel()).ToList();

			return models;
		}

        public static NavTreeNodeModel ToNavTreeNodeModel(this ArticleCategory articleCategory)
        {
            NavTreeNodeModel model = new NavTreeNodeModel()
            {
                CategoryId = articleCategory.ArticleCategoryId,
                ResourceKey = articleCategory.UIResourceKey,
				Name = articleCategory.Name
            };

            return model;
        }

        public static List<NavTreeNodeModel> ToNavTreeNodeModels(this List<ArticleCategory> articleCategories) {
            List<NavTreeNodeModel> models = articleCategories.Select(t => t.ToNavTreeNodeModel()).ToList();
            return models;
        }
	}
}