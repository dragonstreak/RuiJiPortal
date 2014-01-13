using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuiJi.Internal.Models;
using System.Text.RegularExpressions;

namespace RuiJi.Internal.Helpers
{
    public class MenuUrlProcessor
    {
        #region Members

        /// <summary>
        /// the url helper for converting relative path to actual path.
        /// </summary>
        UrlHelper urlHelper;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuUrlProcessor"/> class.
        /// </summary>
        /// <param name="urlHelper">The URL helper.</param>
        public MenuUrlProcessor(UrlHelper urlHelper)
        {
            this.urlHelper = urlHelper;
        }

        #endregion

        #region Public methods

        #region ParseRelativeUrl

        /// <summary>
        /// Parses the relative URL.
        /// </summary>
        /// <param name="mm">The mm.</param>
        public void ParseRelativeUrl(MenuModel mm)
        {
            //process url
            if (!string.IsNullOrEmpty(mm.Url))
                mm.Url = urlHelper.Content(mm.Url);

            //process url in display name
            if (!string.IsNullOrEmpty(mm.DisplayName))
                mm.DisplayName = ParseRelativePathInText(mm.DisplayName);

            foreach (var subMenu in mm.SubMenus)
                ParseRelativeUrl(subMenu);
        }

        #endregion

        #endregion

        #region Private methods

        #region ParseRelativePathInText

        /// <summary>
        /// Parses the relative path in text.
        /// </summary>
        /// <param name="raw">The raw.</param>
        /// <returns></returns>
        private string ParseRelativePathInText(string raw)
        {
            return Regex.Replace(raw, "'~/.+?'", this.CapturedUrl);
        }

        #endregion

        #region CapturedUrl

        /// <summary>
        /// Captureds the URL.
        /// </summary>
        /// <param name="m">The m.</param>
        /// <returns></returns>
        private string CapturedUrl(Match m)
        {
            // get the matched string
            string url = m.ToString();

            //remove ''
            url = url.Trim('\'');

            url = this.urlHelper.Content(url);

            return "'" + url + "'";
        }

        #endregion

        #endregion
    }
}