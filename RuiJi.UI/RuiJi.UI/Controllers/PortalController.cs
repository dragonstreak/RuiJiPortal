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

namespace RuiJi.UI.Controllers
{
    public class PortalController : BaseController
    {
        //
        // GET: /Portal/

        public ActionResult Index()
        {
            return View();
        }

        // no use for now.
        public ActionResult SetCulture(string culture)
        {
            culture = CultureHelper.GetImplementedCulture(culture);

            HttpCookie cookie = Request.Cookies["_culture"];
            if (cookie != null)
            {
                cookie.Value = culture;
            }
            else
            {
                cookie = new HttpCookie("_culture");
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }

            Response.Cookies.Add(cookie);
            return RedirectToAction("HomePage");
        }

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

            return View("NewsCenter");
        }

        public ActionResult SolutionCenter()
        {
            ArticleListModel list = new ArticleListModel();

			var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
			var solutionList = svc.LoadByArticleType(ArticleType.Solution);

			list.Articles = solutionList.ToModels();

            return View("ItemList", list);
        }

        public ActionResult ServiceCenter()
        {
            return View("ServiceCenter");
        }

        public ActionResult SuccessCases()
        {
            return View("SuccessCases");
        }

        public ActionResult Information()
        {
            return View("Information");
        }

        public ActionResult HumanResources()
        {
            return View("HumanResources");
        }

        public ActionResult ContactUs()
        {
            return View("ContactUs");
        }

        public ActionResult Detail(int? articleId)
        {
            ArticleModel model = new ArticleModel();



            return View("ItemDetail", model);
        }
    }
}
