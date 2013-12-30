using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RuiJi.UI.Controllers
{
    public class PortalController : Controller
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
    }
}
