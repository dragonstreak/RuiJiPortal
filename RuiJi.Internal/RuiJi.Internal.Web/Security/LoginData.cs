using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RuiJi.Internal.Web.Security
{
    public class LoginData
    {

        internal LoginData(HttpContext context)
        {

            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            this.Context = context;
            this.Url = context.Request.Url;
            this.Referrer = context.Request.UrlReferrer;

        }

        public HttpContext Context { get; private set; }

        /// <summary>
        /// The current url
        /// </summary>
        public Uri Url { get; private set; }

        /// <summary>
        /// The login refferer URI
        /// </summary>
        public Uri Referrer { get; set; }
        
        /// <summary>
        /// The user name or email address
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The full query string (without the "?")
        /// </summary>
        public string QueryString { get; set; }

        /// <summary>
        /// Flag to indicate not to redirect with the login result
        /// </summary>
        public bool NoRedirect { get; set; }

        /// <summary>
        /// Flag to indicate whether the authentication cookie is persistent
        /// </summary>
        public bool IsPersistent { get; set; }

        /// <summary>
        /// Where to redirect to on successful login
        /// </summary>
        public string OnSuccess { get; set; }

        /// <summary>
        /// Where to redirect to on failed login
        /// </summary>
        public string OnError { get; set; }

        /// <summary>
        /// Flag to indicate if this is a hijacking login (ex. CR from DeepBlue)
        /// </summary>
        public bool IsHijacking { get; set; }

    }
}
