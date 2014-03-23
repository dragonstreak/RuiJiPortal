using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuiJi.DataAccess;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.Internal.Controllers;
using RuiJi.Internal.Extensions;
using RuiJi.Internal.Models;

namespace RuiJi.Internal.Controllers
{
    public class ArticleCategoryController : BaseController
    {
        //
        // GET: /RuiJiInternal/ArticleCategory/

        public ActionResult Index()
        {
            ArticleCategoryListModel model = new ArticleCategoryListModel();
            ArticleCategoryCacheSvc.Refresh();
            model.ArticleCategoryList = ArticleCategoryExtension.GetAllArticleCategory();

            return View(model);
        }


        private IArticleCategoryCacheSvc _articleCategoryCacheSvc;
        private IArticleCategoryCacheSvc ArticleCategoryCacheSvc
        {
            get
            {
                if (_articleCategoryCacheSvc == null)
                {
                    _articleCategoryCacheSvc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategoryCacheSvc>();
                }

                return _articleCategoryCacheSvc;
            }
        }
    }
}
