using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuiJi.Internal.Web.Security
{
    public static class RequestVariableKeys
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Splash = "splash";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string ZFU = "zfu";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string UserName = "UserName";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Password = "Password";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Persistent = "Persistent";
        /// 
        /// </summary>
        public static readonly string Location = "location";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string OnSuccess = "onsuccess";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string OnSuccess2 = "onsuccess2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string OnError = "onerror";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Referer = "referer";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string OnLogout = "onlogout";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string NoRedirect = "noredirect";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string PartnerLogin = "plogin";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string PartnerForgotPassword = "pforgotpwd";

        /// <summary>
        /// Use this action name to determine if the long action of external user is for auto login
        /// </summary>
        public static readonly string ExternalUserAutoLoginActionName = "autoLogin";
        
        /// <summary>
        /// The session id
        /// </summary>
        public static readonly string SessionId = "sid";
    }
}
