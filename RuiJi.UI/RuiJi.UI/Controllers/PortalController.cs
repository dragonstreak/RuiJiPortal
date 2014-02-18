using System;
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
using RuiJi.UI.Resources;
using RuiJi.DataAccess.ArticleCategorys;

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

		//public ActionResult Ruiji(int? pageIndex)
		//{
		//	var tree = NavTreeContext.NavTree.Value;


		//	ArticleListModel list = new ArticleListModel();

		//	if (!pageIndex.HasValue || pageIndex.GetValueOrDefault() <= 0) {
		//		pageIndex = 1;
		//	}

		//	int totalCount = 0;

		//	var articleModelList = this.LoadByArticleCategoryPaged(ArticleCategoryEnum.CompanyInfo, pageIndex.GetValueOrDefault(), RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE, out totalCount);

		//	list.Articles = articleModelList;
		//	list.PageIndex = pageIndex.GetValueOrDefault();
		//	list.PageSize = RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE;
		//	list.TotalCount = totalCount;
		//	list.MenuSectionTitle = Resource.Menu_NewsCenter;
		//	list.IsSuccess = true;

		//	return View("ItemList", list);
		//}

		//public ActionResult NewsCenter(int? pageIndex)
		//{
		//	ArticleListModel list = new ArticleListModel();

		//	if (!pageIndex.HasValue || pageIndex.GetValueOrDefault() <= 0)
		//	{
		//		pageIndex = 1;
		//	}

		//	int totalCount = 0;

		//	var articleModelList = this.LoadByArticleCategoryPaged(ArticleCategoryEnum.News, pageIndex.GetValueOrDefault(), RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE, out totalCount);

		//	list.Articles = articleModelList;
		//	list.ArticleCategoryId = (int)ArticleCategoryEnum.News;
		//	list.PageIndex = pageIndex.GetValueOrDefault();
		//	list.PageSize = RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE;
		//	list.TotalCount = totalCount;
		//	list.MenuSectionTitle = Resource.Menu_NewsCenter;
		//	list.IsSuccess = true;

		//	return View("ItemList", list);
		//}

		//public ActionResult SolutionCenter(int? pageIndex)
		//{
		//	ArticleListModel list = new ArticleListModel();

		//	if (!pageIndex.HasValue || pageIndex.GetValueOrDefault() <= 0)
		//	{
		//		pageIndex = 1;
		//	}

		//	int totalCount = 0;

		//	var articleModelList = this.LoadByArticleCategoryPaged(ArticleCategoryEnum.Solution, pageIndex.GetValueOrDefault(), RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE, out totalCount);

		//	list.Articles = articleModelList;
		//	list.PageIndex = pageIndex.GetValueOrDefault();
		//	list.PageSize = RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE;
		//	list.TotalCount = totalCount;
		//	list.MenuSectionTitle = Resource.Menu_SolutionCenter;
		//	list.IsSuccess = true;

		//	return View("ItemList", list);
		//}

		//public ActionResult ServiceCenter(int? pageIndex)
		//{
		//	ArticleListModel list = new ArticleListModel();

		//	if (!pageIndex.HasValue || pageIndex.GetValueOrDefault() <= 0)
		//	{
		//		pageIndex = 1;
		//	}

		//	int totalCount = 0;

		//	var articleModelList = this.LoadByArticleCategoryPaged(ArticleCategoryEnum.Service, pageIndex.GetValueOrDefault(), RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE, out totalCount);

		//	list.Articles = articleModelList;
		//	list.PageIndex = pageIndex.GetValueOrDefault();
		//	list.PageSize = RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE;
		//	list.TotalCount = totalCount;
		//	list.MenuSectionTitle = Resource.Menu_ServiceCenter;
		//	list.IsSuccess = true;

		//	return View("ItemList", list);
		//}

		//public ActionResult SuccessCases(int? pageIndex)
		//{
		//	ArticleListModel list = new ArticleListModel();

		//	if (!pageIndex.HasValue || pageIndex.GetValueOrDefault() <= 0)
		//	{
		//		pageIndex = 1;
		//	}

		//	int totalCount = 0;

		//	var articleModelList = this.LoadByArticleCategoryPaged(ArticleCategoryEnum.Achievement, pageIndex.GetValueOrDefault(), RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE, out totalCount);

		//	list.Articles = articleModelList;
		//	list.PageIndex = pageIndex.GetValueOrDefault();
		//	list.PageSize = RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE;
		//	list.TotalCount = totalCount;
		//	list.MenuSectionTitle = Resource.Menu_SuccessCases;
		//	list.IsSuccess = true;

		//	return View("ItemList", list);
		//}

		//public ActionResult Information(int? pageIndex)
		//{
		//	ArticleListModel list = new ArticleListModel();

		//	if (!pageIndex.HasValue || pageIndex.GetValueOrDefault() <= 0)
		//	{
		//		pageIndex = 1;
		//	}

		//	int totalCount = 0;

		//	var articleModelList = this.LoadByArticleCategoryPaged(ArticleCategoryEnum.TechResource, pageIndex.GetValueOrDefault(), RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE, out totalCount);

		//	list.Articles = articleModelList;
		//	list.PageIndex = pageIndex.GetValueOrDefault();
		//	list.PageSize = RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE;
		//	list.TotalCount = totalCount;
		//	list.MenuSectionTitle = Resource.Menu_Information;
		//	list.IsSuccess = true;

		//	return View("ItemList", list);
		//}

		//public ActionResult HumanResources(int? pageIndex)
		//{
		//	ArticleListModel list = new ArticleListModel();

		//	if (!pageIndex.HasValue || pageIndex.GetValueOrDefault() <= 0)
		//	{
		//		pageIndex = 1;
		//	}

		//	int totalCount = 0;

		//	var articleModelList = this.LoadByArticleCategoryPaged(ArticleCategoryEnum.HumanResource, pageIndex.GetValueOrDefault(), RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE, out totalCount);

		//	list.Articles = articleModelList;
		//	list.PageIndex = pageIndex.GetValueOrDefault();
		//	list.PageSize = RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE;
		//	list.TotalCount = totalCount;
		//	list.MenuSectionTitle = Resource.Menu_HumanResources;
		//	list.IsSuccess = true;

		//	return View("ItemList", list);
		//}

		//public ActionResult ContactUs(int? pageIndex)
		//{
		//	ArticleListModel list = new ArticleListModel();

		//	if (!pageIndex.HasValue || pageIndex.GetValueOrDefault() <= 0)
		//	{
		//		pageIndex = 1;
		//	}

		//	int totalCount = 0;

		//	var articleModelList = this.LoadByArticleCategoryPaged(ArticleCategoryEnum.ContactUs, pageIndex.GetValueOrDefault(), RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE, out totalCount);

		//	list.Articles = articleModelList;
		//	list.PageIndex = pageIndex.GetValueOrDefault();
		//	list.PageSize = RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE;
		//	list.TotalCount = totalCount;
		//	list.MenuSectionTitle = Resource.Menu_ContactUs;
		//	list.IsSuccess = true;
		//	return View("ItemList", list);
		//}

        public ActionResult ItemList(int categoryId, int? pageIndex)
        {
            ArticleListModel list = new ArticleListModel();

            if (!pageIndex.HasValue || pageIndex.GetValueOrDefault() <= 0)
            {
                pageIndex = 1;
            }

            int totalCount = 0;

            var articleModelList = this.LoadByArticleCategoryPaged(categoryId, pageIndex.GetValueOrDefault(), RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE, out totalCount);
            var articleCategoryModel = this.LoadArticleCategory(categoryId);

            list.Articles = articleModelList;
            list.ArticleCategory = articleCategoryModel;
            list.PageIndex = pageIndex.GetValueOrDefault();
            list.PageSize = RuiJi.UI.Common.Constants.ITEM_LIST_PAGE_SIZE;
            list.TotalCount = totalCount;
            list.IsSuccess = true;
            return View("ItemList", list);
        }

        public ActionResult Detail(int? articleId)
        {
            ArticleModel model = new ArticleModel();

            if (!articleId.HasValue)
            {
                model.IsSuccess = false;
                model.ErrorMsg = string.Format("Invalid articleId: #{0}", articleId);
            }

            model = LoadArticle(articleId.GetValueOrDefault());
            model.IsSuccess = true;

            return View("ItemDetail", model);
        }

        public ActionResult SiteMap()
        {
            ArticleModel model = new ArticleModel();
            model = LoadArticle(RuiJi.UI.Common.SpecialArticle.SiteMapArticleId);
            return View("ItemDetail", model);
        }

        public ActionResult LegalInformation()
        {
            ArticleModel model = new ArticleModel();
            model = LoadArticle(RuiJi.UI.Common.SpecialArticle.LegalInformationArticleId);
            return View("ItemDetail", model);
        }

        public ActionResult Links()
        {
            ArticleModel model = new ArticleModel();
            model = LoadArticle(RuiJi.UI.Common.SpecialArticle.LinksArticleId);
            return View("ItemDetail", model);
        }

        #endregion

        #region Private Methods
        private NavTreeNodeModel LoadArticleCategory(int articleCategoryId)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategorySvc>();
            var articleCategory = svc.LoadById(articleCategoryId);
            return articleCategory.ToNavTreeNodeModel();
        }

        private ArticleModel LoadArticle(int articleId)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
            var article = svc.LoadById(articleId);

            return article.ToModel();
        }

        private List<ArticleModel> LoadByArticleCategory(ArticleCategoryEnum articleCategory)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
            var modelList = svc.LoadByArticleCategoryId((int)articleCategory, true);

            return modelList.ToModels();
        }

        private List<ArticleModel> LoadByArticleCategoryPaged(int articleCategory, int pageIndex, int pageSize, out int totalCount)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
            var result = svc.LoadByArticleCategoryIdWithPaging(new LoadArticleByPagingParams()
            {
                ArticleCategoryId = articleCategory,
                OnlyPublished = true,
                PageIndex = pageIndex,
                PageSize = pageSize
            });

            totalCount = result.Total;
            return result.ArticleList.ToModels();
        }

        private List<ArticleModel> LoadByArticleCategoryPaged(ArticleCategoryEnum articleCategory, int pageIndex, int pageSize, out int totalCount)
        {
            return this.LoadByArticleCategoryPaged((int)articleCategory, pageIndex, pageSize, out totalCount);
        }

        #endregion
    }
}
