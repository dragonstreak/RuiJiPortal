using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using RuiJi.Internal.Models;
using RuiJi.Internal.Common;
using RuiJi.Internal.Security;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using RuiJi.Internal.Context;

namespace RuiJi.Internal.Helpers
{
    public static class MenuHelper
    {
        private static List<MenuModel> _smartMenus = null;
        private static List<MenuModel> _miniMenus = null;
        private static List<MenuModel> _rupeMenus = null;
        private static List<MenuModel> _indoMenus = null;

        private static readonly string script = @"
            <script type='text/javascript'>
            $(function(){
                $('a.parentMenu').click(function(){
                    var parentMenu = this;
                    $(this).next('ul').slideToggle('fast', function(){
                        $(parentMenu).find('span').toggleClass('sub_active');
                    });
                    return false;
                });
            });
            </script> ";


        /// <summary>
        /// Menus helper extension.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="currentMenu">The current menu.</param>
        /// <param name="currentSubMenuName">The current sub menu.</param>
        /// <returns></returns>
        public static MvcHtmlString GenerateMenu(this HtmlHelper helper
            , string currentMenuName
            , string currentSubMenuName
            , RuiJiContext currentUser)
        {
            if (currentUser == null)
                return new MvcHtmlString(string.Empty);

            List<MenuModel> menus = LoadMenus(helper, "~/AppData/Menu.xml");


            var sb = new StringBuilder();

            sb.Append(@"<div id='divLeftMenu' class='left-menu-flat'><ul>");

            foreach (var menu in menus)
            {
                CreateMenu(helper, menu, currentMenuName, currentSubMenuName, currentUser.Roles, sb);
            }

            //append closing div ul
            sb.Append(@"</ul></div>");

            sb.Append(GetStartupScripts());

            return new MvcHtmlString(sb.ToString());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="currentMenuName"></param>
        /// <param name="roles"></param>
        /// <param name="sb"></param>
        /// <returns>The result means if current user can assess the menu item</returns>
        private static bool CreateMenu(HtmlHelper helper
                                            , MenuModel menu
                                            , string currentMenuName
                                            , string currentSubMenuName
                                            , List<string> roles
                                            , StringBuilder sb)
        {

            if (!IsMenuAccessible(menu, roles))
                return false;

            bool isCurrentMenu = (menu.Name == currentMenuName);

            //starting li
            sb.Append(string.Format(@"<li id='li{0}' class='{1}' menu-name='{2}'>"
                                        , menu.Id /*0*/
                                        , isCurrentMenu ? "menu-active" : "menu" /*1*/
                                        , menu.Name /*2*/));
            //, isCurrentMenu ? "true" : "false" /*3*/));
            //, "true" /*3*/));

            //<a> element
            sb.Append(string.Format(@"<a id='m{0}' href='{1}' target='{2}' {3} class='parentMenu'>{4}<span class='indicator'></span></a>"
                                    , menu.Id /*0*/
                                    , menu.Url /*1*/
                                    , menu.Target /*2*/
                                    , string.Empty //strOnclick /*3*/
                                    , menu.DisplayName /*4*/));
            // , strImg /*5*/));


            //
            //  Handle sub menu
            //
            CreateSubMenu(helper, menu, currentSubMenuName, roles, sb);


            sb.Append("</li>"); // for parent memu


            return true;
        }


        /// <summary>
        /// Creates the sub menu.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="parentMenu">The parent menu.</param>
        /// <param name="currentSubMenu">The current sub menu.</param>
        /// <param name="isCurrentMenu">if set to <c>true</c> [is current menu].</param>
        /// <param name="roles">The permissions.</param>
        /// <param name="strOnclick">The STR onclick.</param>
        /// <param name="strImg">The STR img.</param>
        /// <returns></returns>
        private static void CreateSubMenu(HtmlHelper helper
                                            , MenuModel parentMenu
                                            , string currentSubMenuName
                                            , List<string> roles
                                            , StringBuilder sb)
        {
            if ((parentMenu.SubMenus == null) || (parentMenu.SubMenus.Count == 0))
            {
                return;
            }

            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);

            //append submenu starting tag
            sb.Append(string.Format(@"<ul id='ul{0}' class='subMenu'>", parentMenu.Id));

            foreach (var subMenu in parentMenu.SubMenus)
            {
                if (!IsMenuAccessible(subMenu, roles))
                    continue;

                bool isCurrentSubMenu = subMenu.Name.Equals(currentSubMenuName, StringComparison.OrdinalIgnoreCase);
                sb.Append(string.Format(@"<li id='liSub{0}' class='{1}'>"
                                        , subMenu.Id
                                        , isCurrentSubMenu ? "sub-menu-active" : ""));

                //appending submenu a
                if (!string.IsNullOrEmpty(subMenu.ClickAction))
                {
                    sb.Append(string.Format(@"<a id='m{0}' href='{1}' target='{2}' {4}>{3}</a>"
                                                        , subMenu.Id /*0*/
                                                        , subMenu.Url /*1*/
                                                        , subMenu.Target /*2*/
                                                        , subMenu.DisplayName /*3*/
                                                        , "onclick=\"" + subMenu.ClickAction + "\"" /*4*/));
                }
                else
                {
                    sb.Append(string.Format(@"<a id='m{0}' href='{1}' target='{2}'>{3}</a>"
                                                        , subMenu.Id /*0*/
                                                        , subMenu.Url /*1*/
                                                        , subMenu.Target /*2*/
                                                        , subMenu.DisplayName /*3*/));
                }


                //sub menu closing
                sb.Append("</li>");
            }

            //append submenu end tag
            sb.Append(@"</ul>");
        }



        /// <summary>
        /// Determines whether [is menu accessible] [the specified model].
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="permissions">The permissions.</param>
        /// <returns>
        ///   <c>true</c> if [is menu accessible] [the specified model]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsMenuAccessible(MenuModel model, List<string> permissions)
        {
            foreach (var pc in model.PermissionCodes)
            {
                foreach (var p in permissions)
                {
                    if (pc.Equals(p,StringComparison.OrdinalIgnoreCase))
                        return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Gets the menus.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="menuXmlFileRelativePath">The menu XML file relative path.</param>
        /// <returns></returns>
        private static List<MenuModel> LoadMenus(HtmlHelper helper, string menuXmlFileRelativePath)
        {
            //cache menu
            //if (currentSmartMenus != null)
            //    return currentSmartMenus;

            //get current url helper
            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);

            string menuFile = helper.ViewContext.HttpContext.Server.MapPath(menuXmlFileRelativePath);

            XmlSerializer xs = new XmlSerializer(typeof(List<MenuModel>));
            using (XmlReader reader = new XmlTextReader(File.OpenRead(menuFile)))
            {
                List<MenuModel> menus = (List<MenuModel>)xs.Deserialize(reader);
                foreach (var mm in menus)
                {
                    new MenuUrlProcessor(urlHelper).ParseRelativeUrl(mm);
                }

                //currentMenus = menus;

                return menus;
            }
        }

        /// <summary>
        /// Gets the startup scripts.
        /// </summary>
        /// <returns></returns>
        private static string GetStartupScripts()
        {

            return script;
        }
    }
}
