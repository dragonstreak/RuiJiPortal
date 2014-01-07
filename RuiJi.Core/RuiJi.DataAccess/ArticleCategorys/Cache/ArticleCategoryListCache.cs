using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations;
using RuiJi.DataAccess.ArticleCategorys.Data;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ArticleCategorys.Cache
{
    class ArticleCategoryListCache
    {
        private const string CacheKey = "ArticleCategoryListCacheKey";

        private ICacheManager _cacheManager;
        private IArticleCategoryMgr _mgr;

        private static Lazy<ArticleCategoryListCache> _instance = new Lazy<ArticleCategoryListCache>
            (
                () =>
                {
                    IArticleCategoryMgr mgr = new ArticleCategoryMgr();
                    ICacheManager cacheManager = CacheFactory.GetCacheManager();

                    return new ArticleCategoryListCache(cacheManager, mgr);
                }, true
            );

        private ArticleCategoryListCache(ICacheManager cacheManager, IArticleCategoryMgr mgr)
        {
            _cacheManager = cacheManager;
            _mgr = mgr;
        }

        public static ArticleCategoryListCache Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public ReadOnlyCollection<ArticleCategory> ArticleCategorys
        {
            get
            {
                ReadOnlyCollection<ArticleCategory> cacheList = _cacheManager[CacheKey] as ReadOnlyCollection<ArticleCategory>;
                if(cacheList == null)
                {
                    ReadOnlyCollection<ArticleCategory> articleCategoryList = _mgr.LoadAll().AsReadOnly();
                    ExtendedFormatTime expireTime = new ExtendedFormatTime("10 * * * *");

                    _cacheManager.Add(CacheKey, articleCategoryList, CacheItemPriority.Normal, null, expireTime);
                }

                return (ReadOnlyCollection<ArticleCategory>)_cacheManager[CacheKey];
            }
        }

    }
}
