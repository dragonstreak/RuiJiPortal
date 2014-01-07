
using Common.Enums;
namespace RuiJi.UI.Common
{
    public class Constants
    {
        public const int ACTIVITIES_COUNT = 4;
        public const int ITEM_LIST_PAGE_SIZE = 10;
        public const string MENU_NODE_INDENT = "&nbsp;&nbsp;&nbsp;&nbsp;";

        public static readonly ArticleCategoryEnum[] TOP_LEVEL_ARTICLE_CATEGORIES = new ArticleCategoryEnum[] { 
            ArticleCategoryEnum.Achievement
            , ArticleCategoryEnum.CompanyInfo
            , ArticleCategoryEnum.ContactUs
            , ArticleCategoryEnum.HumanResource
            , ArticleCategoryEnum.News
            , ArticleCategoryEnum.Service
            , ArticleCategoryEnum.Solution
            , ArticleCategoryEnum.TechResource
        };
    }

    public class SpecialArticleCategory
    {
        public const int ActivitiesId = 1;
    }

    public class SpecialArticle
    {
        public const int SiteMapArticleId = 1;
        public const int LegalInformationArticleId = 2;
        public const int LinksArticleId = 3;
    }

    public static class AppSettingsKey
    {
        public static string ForumUrl = "forum";
    }
}