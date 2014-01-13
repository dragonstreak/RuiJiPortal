using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using RuiJi.Internal.Common;
using RuiJi.Internal.Context;
using RuiJi.Internal.Web.Module;

namespace RuiJi.Internal.Module
{
    public class RuiJiContextModule: RuiJiContextModuleBase<RuiJiContext>
    {

        #region override method

        protected override void SaveContext(RuiJiContext ruijiContext, HttpContext httpContext)
        {
            if(ruijiContext == null)
            {
                return;
            }

            var ruiJiContextCookieString = RuiJiContextCookieSerializer.Serialize(ruijiContext);
            var encryptRuiJiContextCookieString = RuiJiCryptoGraphy.Instance.EncryptSymmetric(ruiJiContextCookieString);
            var cookie = new HttpCookie(RuiJiContext.ContextCookieKey,encryptRuiJiContextCookieString);
            cookie.Expires = DateTime.Now.AddHours(2);
            if(httpContext.Response.Cookies.AllKeys.Contains(RuiJiContext.ContextCookieKey))
            {
                httpContext.Response.Cookies.Remove(RuiJiContext.ContextCookieKey);
            }

            httpContext.Response.Cookies.Add(cookie);
        }

        protected override RuiJiContext LoadContext(HttpContext context)
        {
            var ruiJiContextCookie = context.Request.Cookies[RuiJiContext.ContextCookieKey];
            if (ruiJiContextCookie == null || ruiJiContextCookie.Expires < DateTime.Now)
            {
                return null;
            }
            
            var cookieValue = ruiJiContextCookie.Value;
            
            var decrypRuiJiContext = RuiJiCryptoGraphy.Instance.DecryptSymmetric(cookieValue);

            RuiJiContext ruijiContext;

            RuiJiContextCookieSerializer.TryDeserialize(decrypRuiJiContext, out ruijiContext);

            return ruijiContext;
        }

        protected override bool IsValidForRequest(HttpRequest request)
        {
            return true;
        }

        #endregion
    }
}