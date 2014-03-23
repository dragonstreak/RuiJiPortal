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
using Common.Enums;

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

            model.ArticleList = ArticleSvc.LoadArticleForManage(model.ArticleCategoryIdQry, model.TitleQry,LanguageType.All, loadPublishArticle).ToListModel();
            model.SetMenu("SiteManagement", "ArticleManager");
            return View(model);
        }
        
        public ActionResult EditArticle(int? articleId)
        {
            ArticleItemModel article;
            if (!articleId.HasValue)
            {
                article = new ArticleItemModel();
            }
            else
            {
                article = ArticleSvc.LoadById(articleId.Value).ToItemModel();
            }

            article.SetMenu("SiteManagement", "ArticleEdit");
            return View("Edit2", article);
        }

        [ValidateInput(false)]
        public JsonResult Save(int articleId,
            string title,
            string summary,
            string contentDetail,
            int articleCategoryId,
            bool ispublished,
            string author,
            int language)
        {
            JsonResultBase result = new JsonResultBase();
            string currentUser = "System";
            if (RuiJiContext.Current != null)
            {
                currentUser = RuiJiContext.Current.UserName;
            }

            Article article;
            try
            {
                if (articleId == 0)
                {
                    article = new Article();
                }
                else
                {
                    article = ArticleSvc.LoadById(articleId);
                }
                article.ArticleId = articleId;
                article.Title = title;
                article.Summary = summary;
                article.ContentDetail = contentDetail;
                article.ArticleCategoryId = articleCategoryId;
                article.IsPublished = ispublished;
                article.Author = author;
                article.LanguageType = language;
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
                    article.InsertBy = currentUser;
                    ArticleSvc.Add(article);
                }
                else
                {
                    article.UpdateBy = currentUser;
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

        public ActionResult EditSuccess(bool isCreate)
        {
            EditSuccessModel model = new EditSuccessModel() { IsCreate = isCreate };
            model.SetMenu("SiteManagement", "ArticleEdit");
            return View(model);
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
