using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuiJi.DataAccess;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.Internal.Extensions;

namespace RuiJi.Internal.Models
{
    public class ArticleCategoryItemModel : BaseModel
    {
        public int ArticleCategoryId { get; set; }
        public string Name { get; set; }
        public string UIResourceKey { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParentCategoryId { get; set; }

        public List<ArticleCategoryItemModel> ArticleCategoryList { get; set; }

        private string _parentCategoryName;
        public string ParentCategoryName 
        {
            get
            {
                if (_parentCategoryName == null)
                {
                    if (ParentCategoryId.HasValue)
                    {
                        var category = ArticleCategoryCacheSvc.LoadAllArticleCategory().FirstOrDefault(_ => _.ArticleCategoryId == ParentCategoryId.Value);
                        if (category != null)
                        {
                            _parentCategoryName = category.Name;
                        }
                    }
                }

                return _parentCategoryName;
            }
        }
        public bool IsShowOnHomePage { get; set; }
        public int HomePageDisplayOrder { get; set; }
        public string CNName { get; set; }
        public string ENName { get; set; }

        private static IArticleCategoryCacheSvc _articleCategoryCacheSvc;
        public static IArticleCategoryCacheSvc ArticleCategoryCacheSvc
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

        public bool Editable
        {
            get
            {
                return this.ParentCategoryId.HasValue && this.ParentCategoryId.Value > 0;
            }
        }

    }
}