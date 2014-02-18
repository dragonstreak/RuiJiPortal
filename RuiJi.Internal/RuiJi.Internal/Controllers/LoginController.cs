using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuiJi.Internal.Models;

namespace RuiJi.Internal.Controllers
{
    public class LoginController : BaseController
    {
        //
        // GET: /Login/

        public ActionResult Index(string loginErrorMsg)
        {
            LoginModel model = new LoginModel();
            model.ErrorMsg = loginErrorMsg;
            return View(model);
        }

        public ActionResult Logon(LoginModel user)
        {

            return RedirectToAction("Index", "Article");            
        }
    }
}
