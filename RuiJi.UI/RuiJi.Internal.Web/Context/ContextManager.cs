using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RuiJi.Internal.Web.Context
{
    public class ContextManager<TContext> where TContext : class, IServerContext
    {
        // Methods
        public static TContext GetContext(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                httpContext = HttpContext.Current;
                if (httpContext == null)
                {
                    throw new ArgumentNullException("httpContext");
                }
            }
            return (httpContext.Items[typeof(TContext)] as TContext);
        }

        public static void SetContext(TContext ruijiContext, HttpContext httpContext)
        {
            if (httpContext == null)
            {
                httpContext = HttpContext.Current;
                if (httpContext == null)
                {
                    throw new ArgumentNullException("httpContext");
                }
            }
            httpContext.Items[typeof(TContext)] = ruijiContext;
        }

    }
}
