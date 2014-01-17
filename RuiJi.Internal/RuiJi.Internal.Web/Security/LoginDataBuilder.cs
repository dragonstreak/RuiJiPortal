using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RuiJi.Internal.Web.Security
{
    public static class LoginDataBuilder
    {

        public static LoginData CreateLoginData(HttpContext context)
        {

            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            var loginData = new LoginData(context)
            {
                Referrer = GetReferrerUrl(context),

                UserName = GetRequestValue(context, RequestVariableKeys.UserName),
                Password = GetRequestValue(context, RequestVariableKeys.Password),
                
                NoRedirect = GetRequestBoolean(context, RequestVariableKeys.NoRedirect),
                IsPersistent = GetRequestBoolean(context, RequestVariableKeys.Persistent),
                
                OnSuccess = GetRequestValue(context, RequestVariableKeys.OnSuccess) ?? GetRequestValue(context, RequestVariableKeys.Location),                
                OnError = GetRequestValue(context, RequestVariableKeys.OnError),

                QueryString = GetQueryString(context),

            };

            return loginData;
        }

        private static Uri GetReferrerUrl(HttpContext context)
        {
            Uri referrer;

            string referrerString;

            referrerString = context.Request[RequestVariableKeys.Referer];

            if (!string.IsNullOrEmpty(referrerString)
                && System.Uri.IsWellFormedUriString(referrerString, UriKind.Absolute))
            {
                referrer = new Uri(referrerString);
             
            }
            else if (context.Request.UrlReferrer != null)
            {
                referrer = context.Request.UrlReferrer;
            }
            else
            {
                referrer = context.Request.Url;
            }

            return referrer;
        }

        private static string GetRequestValue(HttpContext context, string requestKey)
        {

            string val = context.Request.QueryString[requestKey];

            if (val == null)
            {
                val = context.Request.Form[requestKey];
            }

            return val;
        }

        private static bool GetRequestBoolean(HttpContext context, string requestKey)
        {

            var val = context.Request[requestKey];

            if (string.IsNullOrEmpty(val))
            {
                return false;
            }

            val = val.ToLowerInvariant();

            if (val == "true" || val == "1" || val == "on")
            {
                return true;
            }

            return false;

        }

        private static string GetQueryString(HttpContext context)
        {
            var qs = context.Request.Url.Query;

            if (!string.IsNullOrEmpty(qs))
            {
                return qs.Substring(1);
            }

            return null;
        }        
    }
}
