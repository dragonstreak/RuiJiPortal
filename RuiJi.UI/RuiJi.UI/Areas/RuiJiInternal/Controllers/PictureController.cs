using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuiJi.Internal.Models;

namespace RuiJi.Internal.Controllers
{
    public class PictureController : BaseController
    {
        //
        // GET: /RuiJiInternal/Picture/

        public ActionResult Index()
        {
            PictureListModel model = new PictureListModel();
            model.SetMenu("SiteManagement", "PictureManage");
            return View(model);
        }

        public ActionResult HomePage(FormCollection form)
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file.ContentLength > 0)
                {
                    file.SaveAs(Server.MapPath("~/Contents/UI/Images/ruiji/378.jpg"));
                }
            }

            return RedirectToAction("Index");
        }
    }
}
