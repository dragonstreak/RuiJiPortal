using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using RuiJi.Internal.Common;
using RuiJi.Internal.Context;
using RuiJi.Internal.Web.Module;
using RuiJi.Internal.Web.Utility;

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

        protected override RuiJiContext LoadContext(HttpContext httpContext)
        {
            var ruiJiContextCookie = httpContext.Request.Cookies[RuiJiContext.ContextCookieKey];
            if (ruiJiContextCookie == null)
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
            bool isValid = false;
            string extension = null;

            // Only run context for aspx/ashx requests
            if (WebUtility.TryGetFileExtension(request.Url, ref extension))
            {
                extension = extension.ToLowerInvariant();

                if (extension == "aspx" || extension == "ashx" || extension == "asmx" || extension == "mvc" )
                {
                    isValid = true;
                }
            }
            else
            {
                // mvc request without an extension...                    
                // ignore the init mvc pages
                string mvcPath = request.Path.ToLowerInvariant();
                if (!(mvcPath.IndexOf("/login", StringComparison.OrdinalIgnoreCase) > 0))
                {
                    isValid = true;
                }
            }

            // Exclude some requests
            if (isValid)
            {
                string path = request.AppRelativeCurrentExecutionFilePath.ToLowerInvariant();

                if (path.StartsWith("~/_tools/"))
                {
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            }

            if (request.Path.ToLowerInvariant().Contains("/_jtemplates/"))
            {
                isValid = false;
            }

            if (!isValid)
            {
               //To Do write log to DB
            }

            return isValid;
        }

        #endregion
    }
}