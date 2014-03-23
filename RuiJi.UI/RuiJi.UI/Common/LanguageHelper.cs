using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Enums;
using RuiJi.DataAccess;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.Web.Helper;

namespace RuiJi.UI.Common
{
    public class LanguageHelper
    {
        public static LanguageType GetLanguageTypeByCulture(string cultureName)
        {
            if (string.IsNullOrWhiteSpace(cultureName))
            {
                return LanguageType.CN;
            }

            if (cultureName.Equals(CultureHelper.CultureCN, StringComparison.OrdinalIgnoreCase))
            {
                return LanguageType.CN;
            }

            if (cultureName.Equals(CultureHelper.CultureEN, StringComparison.OrdinalIgnoreCase))
            {
                return LanguageType.EN;
            }

            return LanguageType.CN;
        }

        public static string GetArticleCategoryUIName(int categoryId)
        {
            string cultureName = GetCurrentCulture();
            string categoryName = string.Empty;
            var languageType = GetLanguageTypeByCulture(cultureName);
            var category = ArticleCategoryCacheSvc.LoadAllArticleCategory().FirstOrDefault(_ => _.ArticleCategoryId == categoryId);
            if (category != null)
            {
                switch (languageType)
                {
                    case LanguageType.CN:
                        categoryName = category.CNName;
                        break;
                    case LanguageType.EN:
                        categoryName = category.ENName;
                        break;
                    default:
                        categoryName = category.CNName;
                        break;
                }
            }

            return categoryName;
        }

        public static string GetCurrentCulture()
        {
            var cookie = HttpContext.Current.Request.Cookies["_culture"];
            if (cookie != null)
            {
                return cookie.Value;
            }
            else
            {
                return CultureHelper.CultureCN;
            }
        }


        private static IArticleCategoryCacheSvc _articleCategoryCacheSvc;
        private static IArticleCategoryCacheSvc ArticleCategoryCacheSvc
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