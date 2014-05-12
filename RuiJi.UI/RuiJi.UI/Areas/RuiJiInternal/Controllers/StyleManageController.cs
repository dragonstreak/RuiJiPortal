using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuiJi.Internal.Models;
using System.IO;
using RuiJi.DataAccess.SiteSettings;
using RuiJi.DataAccess;

namespace RuiJi.Internal.Controllers
{
    public class StyleManageController : BaseController
    {
        private const string StyleFile1 = "~/sea-modules/assets/ruiji/src/style.css";
        private const string StyleFile2 = "~/sea-modules/assets/ruiji/src/style2.css";

        //
        // GET: /RuiJiInternal/StyleManage/

        public ActionResult Index()
        {
            StyleItemModel model = new StyleItemModel();
            return View(model);
        }

        public ActionResult Edit(int EditFileId)
        {
            StyleItemModel model = new StyleItemModel();
            model.EditFileId = EditFileId;
            string filePath = string.Empty;
            if (EditFileId == 1)
            {
                filePath = System.Web.HttpContext.Current.Server.MapPath(StyleFile1);
            }
            else
            {
                filePath = System.Web.HttpContext.Current.Server.MapPath(StyleFile2);
            }

            StreamReader sr = new StreamReader(filePath);
            model.StyleDetail = sr.ReadToEnd();
            sr.Close();
            return View("Index", model);
        }

        public ActionResult Save(int EditFileId)
        {
            string styleDetail = Request.Form["StyleDetail"];
            string filePath = string.Empty;
            if (EditFileId == 1)
            {
                filePath = System.Web.HttpContext.Current.Server.MapPath(StyleFile1);
            }
            else
            {
                filePath = System.Web.HttpContext.Current.Server.MapPath(StyleFile2);
            }

            StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8);
            sw.Write(styleDetail);
            sw.Close();

            JsonResultBase result = new JsonResultBase();
            result.IsSuccess = true;
            return Json(result);
        }

        public ActionResult Apply(int ApplyFileId)
        {
            var siteSetting = SSSvc.Load();
            if (ApplyFileId == 1)
            {
                siteSetting.MasterCSSFile = StyleFile1;
            }
            else
            {
                siteSetting.MasterCSSFile = StyleFile2;
            }

            siteSetting.CSSVersion += 1;

            SSSvc.Update(siteSetting);

            SiteSettingSvc.Refresh();

            JsonResultBase result = new JsonResultBase();
            result.IsSuccess = true;
            return Json(result);
        }


        private static ISiteSettingSvc _siteSettingSvc;
        private static ISiteSettingSvc SSSvc
        {
            get
            {
                if (_siteSettingSvc == null)
                {
                    _siteSettingSvc = RuiJiPortalServiceLocator.Instance.GetSvc<ISiteSettingSvc>();
                }

                return _siteSettingSvc;
            }
        }
    }
}
