﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuiJi.Internal.Models;

namespace RuiJi.Internal.Controllers
{
    public class ArticleController : BaseController
    {
        //
        // GET: /Article/

        public ActionResult Index()
        {
            ArticleListModel model = new ArticleListModel();
            model.SetMenu("SiteManagement", "ArticleManager");
            return View(model);
        }

    }
}
