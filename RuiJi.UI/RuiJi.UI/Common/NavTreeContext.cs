using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Enums;
using RuiJi.DataAccess;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.DataAccess.Articles;
using RuiJi.DataAccess.Models;
using RuiJi.UI.Models;
using RuiJi.UI.Extensions;
using System.Threading;

namespace RuiJi.UI.Common
{
    public class NavTreeContext
    {
        static NavTreeContext()
        {
            NavTree = LoadTree();
        }

        public static List<NavTreeNodeModel> NavTree;

        public static void Refresh()
        {
            NavTree = LoadTree();
        }

        public static List<NavTreeNodeModel> Path(int articleCategoryId)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategorySvc>();
            var list = svc.LoadArticleCategoryPath(articleCategoryId);
            return list.ToNavTreeNodeModels();
        }

		private static List<NavTreeNodeModel> _homePageShown = null;
		public static List<NavTreeNodeModel> HomePageShown {
			get {
				if (_homePageShown == null) {
					_homePageShown = LoadHomePageShown();
				}
				return _homePageShown;
			}
		}

        private static List<ArticleModel> _activities = null;
        public static List<ArticleModel> Activities
        {
            get
            {
                if (_activities == null)
                {
                    _activities = LoadActivities(Constants.ACTIVITIES_COUNT);
                }
                return _activities;
            }
        }

        public static NavTreeNodeModel StepIn
        {
            get
            {
                return NavTree.First(t => t.CategoryId == (int)ArticleCategoryEnum.CompanyInfo);
            }
        }

        public static NavTreeNodeModel ContactUs
        {
            get
            {
                return NavTree.First(t => t.CategoryId == (int)ArticleCategoryEnum.ContactUs);
            }
        }

        public static NavTreeNodeModel HumanResources
        {
            get
            {
                return NavTree.First(t => t.CategoryId == (int)ArticleCategoryEnum.HumanResource);
            }
        }

        public static NavTreeNodeModel NewsCenter
        {
            get
            {
                return NavTree.First(t => t.CategoryId == (int)ArticleCategoryEnum.News);
            }
        }

        public static NavTreeNodeModel ServiceCenter
        {
            get
            {
                return NavTree.First(t => t.CategoryId == (int)ArticleCategoryEnum.Service);
            }
        }

        public static NavTreeNodeModel SolutionCenter
        {
            get
            {
                return NavTree.First(t => t.CategoryId == (int)ArticleCategoryEnum.Solution);
            }
        }

        public static NavTreeNodeModel Information
        {
            get
            {
                return NavTree.First(t => t.CategoryId == (int)ArticleCategoryEnum.TechResource);
            }
        }

        public static NavTreeNodeModel SuccessCases
        {
            get
            {
                return NavTree.First(t => t.CategoryId == (int)ArticleCategoryEnum.Achievement);
            }
        }

        private static List<NavTreeNodeModel> LoadTree()
        {
            var navTree1 = LoadTree((int)ArticleCategoryEnum.CompanyInfo);
            var navTree2 = LoadTree((int)ArticleCategoryEnum.News);
            var navTree3 = LoadTree((int)ArticleCategoryEnum.Solution);
            var navTree4 = LoadTree((int)ArticleCategoryEnum.Service);
            var navTree5 = LoadTree((int)ArticleCategoryEnum.Achievement);
            var navTree6 = LoadTree((int)ArticleCategoryEnum.TechResource);
            var navTree7 = LoadTree((int)ArticleCategoryEnum.HumanResource);
            var navTree8 = LoadTree((int)ArticleCategoryEnum.ContactUs);

            navTree1.IsTopLevel = true;
            navTree2.IsTopLevel = true;
            navTree3.IsTopLevel = true;
            navTree4.IsTopLevel = true;
            navTree5.IsTopLevel = true;
            navTree6.IsTopLevel = true;
            navTree7.IsTopLevel = true;
            navTree8.IsTopLevel = true;

            List<NavTreeNodeModel> tree = new List<NavTreeNodeModel>(8);
            tree.Add(navTree1);
            tree.Add(navTree2);
            tree.Add(navTree3);
            tree.Add(navTree4);
            tree.Add(navTree5);
            tree.Add(navTree6);
            tree.Add(navTree7);
            tree.Add(navTree8);

            return tree;
        }

        private static NavTreeNodeModel LoadTree(int articleCategoryId, bool? isShownOnHomePage = null)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategorySvc>();

            ArticleCategory category = svc.LoadById(articleCategoryId);

            var model = LoadTree(category);

            return model;
        }

        private static NavTreeNodeModel LoadTree(ArticleCategory category, bool? isShownOnHomePage = null)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategorySvc>();

            List<ArticleCategory> childCategories = svc.LoadByParentId(category.ArticleCategoryId);

            if (isShownOnHomePage.HasValue)
            {
                childCategories = childCategories.Where(t => t.IsShowOnHomePage == isShownOnHomePage.Value).ToList();
            }

            NavTreeNodeModel model = category.ToNavTreeNodeModel();

            if (childCategories.Count <= 0)
            {
                return model;
            }

            childCategories.ForEach(t =>
            {
                NavTreeNodeModel childNode = LoadTree(t);
                
                ArticleCategoryEnum categoryEnum = (ArticleCategoryEnum)Enum.Parse(typeof(ArticleCategoryEnum), category.ArticleCategoryId.ToString());
                if (Constants.TOP_LEVEL_ARTICLE_CATEGORIES.Contains(categoryEnum))
                {
                    childNode.IsSubTopLevel = true;
                }

                model.Children.Add(childNode);
            });

            return model;
        }

		private static List<NavTreeNodeModel> LoadHomePageShown() {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategoryCacheSvc>();
            var topLevelArticleCategories = svc.LoadAllTopLevelHomePageShown().OrderBy(t => t.HomePageDisplayOrder).ToList();

            List<NavTreeNodeModel> result = new List<NavTreeNodeModel>();

            topLevelArticleCategories.ForEach(t =>
            {
                var treeNode = LoadTree(t, true);
                result.Add(treeNode);
            });

            return result;
		}

        private static List<ArticleModel> LoadActivities(int count)
        {
            var svc = RuiJiPortalServiceLocator.Instance.GetSvc<IArticleSvc>();
            LanguageType language = LanguageHelper.GetLanguageTypeByCulture(Thread.CurrentThread.CurrentUICulture.Name);
            var articles = svc.LoadByArticleCategoryId(SpecialArticleCategory.ActivitiesId, language, true);

            var list = articles.Take(count).ToModels();
            return list;
        }
    }

}