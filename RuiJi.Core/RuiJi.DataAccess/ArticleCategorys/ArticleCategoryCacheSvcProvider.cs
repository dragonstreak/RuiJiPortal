using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuiJi.DataAccess.ArticleCategorys
{
    [ServiceProviderBinding]
    internal class ArticleCategoryCacheSvcProvider : ServiceProviderBase<IArticleCategoryCacheSvc>
    {
        protected override IArticleCategoryCacheSvc GetServiceCore()
        {            
            return new ArticleCategoryCacheSvc();
        }
    }
}
