using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.ArticleCategorys;
using RuiJi.DataAccess.Articles.Data;

namespace RuiJi.DataAccess.Articles
{
    [ServiceProviderBinding]
    internal class ArticleSvcProvider : ServiceProviderBase<IArticleSvc>
    {
        protected override IArticleSvc GetServiceCore()
        {
            var dataMgr = CreateArticleMgr();
            var articleCategorySvc = CreateArticleCategorySvc();
         
            return new ArticleSvc(
                dataMgr
                , articleCategorySvc
                );
        }

        IArticleMgr CreateArticleMgr()
        {
            return new ArticleMgr();
        }

        IArticleCategorySvc CreateArticleCategorySvc()
        {
            return RuiJiPortalServiceLocator.Instance.GetSvc<IArticleCategorySvc>();
        }
    }
}
