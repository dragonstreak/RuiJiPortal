using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuiJi.UI.Models;
using System.Web.Mvc.Html;
using System.Web.Mvc;
using System.Text;

namespace RuiJi.UI.Common
{
    public class RenderManger
    {
        // Only renders until subtop
        public static void RenderNewsSection(StringBuilder stringBuilder, NavTreeNodeModel treeNode, HtmlHelper<dynamic> htmlHelper)
        {
            string linkText = ResourceManager.GetLocalizedString(treeNode.ResourceKey);

            if (treeNode.IsTopLevel)
            {
                string actionLink = htmlHelper.ActionLink(linkText, "NewsCenter").ToHtmlString();
                stringBuilder.Append(string.Format("<li><strong>{0}</strong></li>", actionLink));

                if (treeNode.Children.Count > 0)
                {
                    foreach (var node in treeNode.Children)
                    {
                        RenderNewsSection(stringBuilder, node, htmlHelper);
                    }
                }
            }
            else if (treeNode.IsSubTopLevel)
            {
                string link = htmlHelper.ActionLink(linkText, "ItemList", new { categoryId = treeNode.CategoryId, title = linkText }).ToHtmlString();

                stringBuilder.Append(string.Format("<li>{0}</li>", link));
            }
            else
            {
                return;
            }
        }

        public static void RenderMenuTreeChildren(StringBuilder stringBuilder, NavTreeNodeModel treeNode, HtmlHelper<dynamic> htmlHelper, string indention = "")
        {
            var linkText = ResourceManager.GetLocalizedString(treeNode.ResourceKey);
            string menuNode = "";

            if (treeNode.IsTopLevel)
            {
                menuNode = string.Format("<h3>{0}</h3><ul>", linkText);
            }
            else
            {
                var htmlAction = htmlHelper.ActionLink(linkText, "ItemList", new { categoryId = treeNode.CategoryId });

                menuNode = htmlAction.ToHtmlString();

                if (treeNode.IsSubTopLevel)
                {
                    menuNode = string.Format("<strong>{0}</strong>", menuNode);
                }
                else
                {
                    menuNode = string.Format("{0}{1}", indention, menuNode);
                }

                menuNode = string.Format("<li>{0}</li>", menuNode);

                
            }

            stringBuilder.Append(menuNode);

            if (treeNode.Children.Count > 0)
            {
                foreach (var subNode in treeNode.Children)
                {
                    RenderMenuTreeChildren(stringBuilder, subNode, htmlHelper, indention + Constants.MENU_NODE_INDENT);
                }
            }

            if (treeNode.IsTopLevel)
            {
                stringBuilder.Append("</ul>");
            }
        }
    }
}