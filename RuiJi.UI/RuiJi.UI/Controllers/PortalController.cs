using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using RuiJi.UI.Common;
using RuiJi.Web.MvcBase;

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
            return View("SolutionCenter");
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
    }
}
