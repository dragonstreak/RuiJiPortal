using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Articles.Data;

namespace RuiJi.DataAccess.Articles
{
    [ServiceProviderBinding]
    internal class ArticleSvcProvider : ServiceProviderBase<IArticleSvc>
    {
        protected override IArticleSvc GetServiceCore()
        {
            var dataMgr = CreateArticleMgr();
         
            return new ArticleSvc(
                dataMgr
                );
        }

        IArticleMgr CreateArticleMgr()
        {
            return new ArticleMgr();
        }
    }
}
