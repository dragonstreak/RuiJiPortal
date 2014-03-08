using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RuiJiRoot.Controllers
{
    public class HomeController : Controller
    {
        public RedirectResult Index()
        {
           return Redirect("~/RuiJiPortal");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
