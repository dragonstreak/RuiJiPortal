using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuiJi.DataAccess;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.DataAccess.Models;
using RuiJi.Internal.Context;
using RuiJi.Internal.Controllers;
using RuiJi.Internal.Extensions;
using RuiJi.Internal.Models;
using RuiJi.UI.Common;

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

        public ViewResult Edit(int articleCategoryId)
        {
            ArticleCategoryItemModel model;
            var category = ArticleCategoryCacheSvc.LoadAllArticleCategory().FirstOrDefault(_ => _.ArticleCategoryId == articleCategoryId);
            if (category != null)
            {
                model = category.ToItemModel();
                model.ArticleCategoryList = ArticleCategoryExtension.GetAllArticleCategory();
            }
            else
            {
                model = null;
            }

            return View(model);
        }

        public ViewResult New()
        {
            ArticleCategoryItemModel model = new ArticleCategoryItemModel();
            model.ArticleCategoryList = ArticleCategoryExtension.GetAllArticleCategory();
            return View("Edit",model);
        }

        public JsonResult Save(int articleCategoryId, string name, string cnname, string enname, int? parentCategoryId, bool isShowOnHomePage, int? homePageDisplayOrder)
        {
            JsonResultBase result = new JsonResultBase();
            try
            {
                ArticleCategory category;
                if (articleCategoryId > 0)
                {
                    category = ArticleCategoryCacheSvc.LoadAllArticleCategory().FirstOrDefault(_ => _.ArticleCategoryId == articleCategoryId);
                }
                else
                {
                    category = new ArticleCategory();
                }
                string currentUser = "System";
                if (RuiJiContext.Current != null)
                {
                    currentUser = RuiJiContext.Current.UserName;
                }

                category.Name = name;
                category.CNName = cnname;
                category.ENName = enname;
                if (parentCategoryId.HasValue && parentCategoryId.Value > 0)
                {
                    category.ParentCategoryId = parentCategoryId;
                }
                category.Description = category.CNName;
                category.IsShowOnHomePage = isShowOnHomePage;
                if (homePageDisplayOrder.HasValue)
                {
                    category.HomePageDisplayOrder = homePageDisplayOrder.Value;
                }
                category.UIResourceKey = name;      

                if (category.ArticleCategoryId > 0)
                {
                    category.UpdateBy = currentUser;
                    ArticleCategorySvc.Update(category);
                }
                else
                {
                    category.CreateBy = currentUser;
                    ArticleCategorySvc.Add(category);
                }
                         
                ArticleCategoryCacheSvc.Refresh();
                NavTreeContext.Refresh();
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }
            return Json(result);

        }

        public JsonResult Delete(int articleCategoryId)
        {
            JsonResultBase result = new JsonResultBase();

            string currentUser = "System";
            if (RuiJiContext.Current != null)
            {
                currentUser = RuiJiContext.Current.UserName;
            }
            ArticleCategorySvc.Delete(articleCategoryId, currentUser);
            ArticleCategoryCacheSvc.Refresh();
            NavTreeContext.Refresh();
            result.IsSuccess = true;

            return Json(result);
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

        private IArticleCategorySvc _articleCategorySvc;
        private IArticleCategorySvc ArticleCategorySvc
        {
            get
            {
                if (_articleCategorySvc == null)
                {
                    _articleCategorySvc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategorySvc>();
                }

                return _articleCategorySvc;
            }
        }
    }
}
