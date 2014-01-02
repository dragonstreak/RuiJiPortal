﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Common.Enums;
using RuiJi.DataAccess;
using RuiJi.DataAccess.Articles;
using RuiJi.UI.Common;
using RuiJi.UI.Models;
using RuiJi.Web.Helper;
using RuiJi.Web.MvcBase;
using RuiJi.UI.Extensions;

namespace RuiJi.UI.Controllers
{
    public class PortalController : BaseController
    {
        #region Public Methods
        //
        // GET: /Portal/

        public ActionResult Index()
        {
            return View();
        }

        // no use for now.
        //public ActionResult SetCulture(string culture)
        //{
        //    culture = CultureHelper.GetImplementedCulture(culture);

        //    HttpCookie cookie = Request.Cookies["_culture"];
        //    if (cookie != null)
        //    {
        //        cookie.Value = culture;
        //    }
        //    else
        //    {
        //        cookie = new HttpCookie("_culture");
        //        cookie.Value = culture;
        //        cookie.Expires = DateTime.Now.AddYears(1);
        //    }

        //    Response.Cookies.Add(cookie);
        //    return RedirectToAction("HomePage");
        //}

        public ActionResult HomePage()
        {
            return View("HomePage");
        }

        public ActionResult Ruiji()
        {
            return View("Ruiji");
        }

        public ActionResult NewsCenter()
        {
            ArticleListModel list = new ArticleListModel();

            var articleModelList = this.LoadByArticleType(ArticleType.News);

            list.Articles = articleModelList;
            list.IsSuccess = true;

            return View("ItemList", list);
        }

        public ActionResult SolutionCenter()
        {
            ArticleListModel list = new ArticleListModel();

            var articleModelList = this.LoadByArticleType(ArticleType.Solution);

            list.Articles = articleModelList;
            list.IsSuccess = true;

            return View("ItemList", list);
        }

        public ActionResult ServiceCenter()
        {
            ArticleListModel list = new ArticleListModel();

            var articleModelList = this.LoadByArticleType(ArticleType.Service);

            list.Articles = articleModelList;
            list.IsSuccess = true;

            return View("ItemList", list);
        }

        public ActionResult SuccessCases()
        {
            ArticleListModel list = new ArticleListModel();

            var articleModelList = this.LoadByArticleType(ArticleType.Achievement);

            list.Articles = articleModelList;
            list.IsSuccess = true;

            return View("ItemList", list);
        }

        public ActionResult Information()
        {
            ArticleListModel list = new ArticleListModel();

            var articleModelList = this.LoadByArticleType(ArticleType.TechResource);

            list.Articles = articleModelList;
            list.IsSuccess = true;

            return View("ItemList", list);
        }

        public ActionResult HumanResources()
        {
            ArticleListModel list = new ArticleListModel();

            var articleModelList = this.LoadByArticleType(ArticleType.HumanResource);

            list.Articles = articleModelList;
            list.IsSuccess = true;

            return View("ItemList", list);
        }

        public ActionResult ContactUs()
        {
            ArticleListModel list = new ArticleListModel();

            var articleModelList = this.LoadByArticleType(ArticleType.ContactUs);

            list.Articles = articleModelList;

            list.IsSuccess = true;
            return View("ItemList", list);
        }

        public ActionResult Detail(int? articleId)
        {
            ArticleModel model = new ArticleModel();

            if (!articleId.HasValue)
            {
                model.IsSuccess = false;
                model.ErrorMsg = string.Format("Invalid articleId: {#0}", articleId);
            }

            model = LoadArticle(articleId.GetValueOrDefault());
            model.IsSuccess = true;

            return View("ItemDetail", model);
        }

        public ActionResult SiteMap()
        {
            ArticleModel model = new ArticleModel();
            model = LoadArticle(RuiJi.UI.Common.Constants.SiteMapArticleId);
            return View("ItemDetail", model);
        }

        public ActionResult LegalInformation()
        {
            ArticleModel model = new ArticleModel();
            model = LoadArticle(RuiJi.UI.Common.Constants.LegalInformationArticleId);
            return View("ItemDetail", model);
        }

        public ActionResult Links()
        {
            ArticleModel model = new ArticleModel();
            model = LoadArticle(RuiJi.UI.Common.Constants.LinksArticleId);
            return View("ItemDetail", model);
        }

        #endregion

        #region Private Methods

        private ArticleModel LoadArticle(int articleId)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
            var article = svc.LoadById(articleId);

            return article.ToModel();
        }

        private List<ArticleModel> LoadByArticleType(ArticleType type)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
            var modelList = svc.LoadByArticleType(type);

            return modelList.ToModels();
        }

        #endregion
    }
}
