using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.ArticleCategorys.Data;

namespace RuiJi.DataAccess.ArticleCategorys
{
    [ServiceProviderBinding]
    internal class ArticleCategorySvcProvider : ServiceProviderBase<IArticleCategorySvc>
    {
        protected override IArticleCategorySvc GetServiceCore()
        {
            var mgr = CreateArticleCategoryMgr();
            return new ArticleCategorySvc(mgr);
        }

        IArticleCategoryMgr CreateArticleCategoryMgr()
        {
            var mgr = new ArticleCategoryMgr();
            return mgr;
        }
    }
}
