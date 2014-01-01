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
				Abstract = "...",
				ArticleId = article.ArticleId,
				Author = article.Author,
				ContentDetail = article.ContentDetail,
				PublishDate = article.PublishDate.GetValueOrDefault(),
				Title = article.Title
			};

			return model;
		}

		public static List<ArticleModel> ToModels(this List<Article> articles) {
			List<ArticleModel> models = null;

			models = articles.Select(t => t.ToModel()).ToList();

			return models;
		}
	}
}