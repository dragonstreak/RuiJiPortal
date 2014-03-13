using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using RuiJi.DataAccess;
using RuiJi.DataAccess.Models;
using RuiJi.DataAccess.User;
using RuiJi.Internal.Context;
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
            string errorMsg = string.Empty;
            if (string.IsNullOrWhiteSpace(user.UserName))
            {
                errorMsg = "Missing UserName";
                return RedirectToAction("Index", new { loginErrorMsg  = errorMsg});
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                errorMsg = "Missing UserName";
                return RedirectToAction("Index", new { loginErrorMsg = errorMsg });
            }

            var encryptPW = RuiJiCryptoGraphy.Instance.CreateHash(user.Password);
            if (UserSvc.IsVaildUser(user.UserName, encryptPW))
            {
                SystemUser sysUser = UserSvc.LoadByName(user.UserName);
                RuiJiContext ruijiContext = new RuiJiContext(sysUser.UserId, sysUser.UserName, sysUser.Roles);

                RuiJiContext.Current = ruijiContext;
                Response.Redirect("~/RuiJiInternal/Article", true);
                return null;
            }
            else
            {
                errorMsg = "UserName or Password error!";
                return RedirectToAction("Index", new { loginErrorMsg = errorMsg });
            }

            
        }


        private IUserSvc userSvc;
        private IUserSvc UserSvc
        {
            get
            {
                if (userSvc == null)
                {
                    userSvc = RuiJiPortalServiceLocator.Instance.GetSvc<IUserSvc>();
                }

                return userSvc;
            }
        }
    }
}
