using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuiJi.DataAccess;
using RuiJi.DataAccess.Articles;
using RuiJi.Internal.Models;
using RuiJi.Internal.Extensions;
using RuiJi.DataAccess.Models;
using RuiJi.Internal.Context;

namespace RuiJi.Internal.Controllers
{
    public class ArticleController : BaseController
    {
        //
        // GET: /Article/

        public ActionResult Index()
        {
            ArticleListModel model = new ArticleListModel();
            model.SetMenu("SiteManagement", "ArticleManager");
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ArticleListModel model)
        {
            bool? loadPublishArticle;
            if (model.IsPublishedQry == 1)
            {
                loadPublishArticle = true;
            }
            else if (model.IsPublishedQry == 0)
            {
                loadPublishArticle = false;
            }
            else
            {
                loadPublishArticle = null;
            }

            model.ArticleList = ArticleSvc.LoadArticleForManage(model.ArticleCategoryIdQry, model.TitleQry, loadPublishArticle).ToListModel();
            model.SetMenu("SiteManagement", "ArticleManager");
            return View(model);
        }

        public ViewResult Create()
        {
            ArticleItemModel article = new ArticleItemModel();
            return View("Edit", article);
        }

        public ViewResult Edit(int articleId)
        {
            var article = ArticleSvc.LoadById(articleId).ToItemModel();
            return View("Edit", article);
        }

        public ActionResult EditArticle()
        {
            ArticleItemModel article = new ArticleItemModel();
            article.SetMenu("SiteManagement", "ArticleEdit");
            return View("Edit2", article);
        }

        public JsonResult Save(int articleId,
            string title,
            string summary,
            string contentDetail,
            int articleCategoryId,
            bool ispublished,
            string author)
        {
            JsonResultBase result = new JsonResultBase();
            try
            {
                Article article = new Article();
                article.ArticleId = articleId;
                article.Title = title;
                article.Summary = summary;
                article.ContentDetail = contentDetail;
                article.ArticleCategoryId = articleCategoryId;
                article.IsPublished = ispublished;
                article.Author = author;
                if (ispublished)
                {
                    article.PublishDate = DateTime.UtcNow;
                }
                else
                {
                    article.PublishDate = null;
                }

                if (articleId == 0)
                {
                    article.InsertBy = RuiJiContext.Current.UserName;
                    ArticleSvc.Add(article);
                }
                else
                {
                    article.UpdateBy = RuiJiContext.Current.UserName;
                    ArticleSvc.Update(article);
                }
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }
            return Json(result);
        }


        private IArticleSvc _articleSvc;
        private IArticleSvc ArticleSvc
        {
            get
            {
                if (_articleSvc == null)
                {
                    _articleSvc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
                }

                return _articleSvc;
            }
        }
    }
}
