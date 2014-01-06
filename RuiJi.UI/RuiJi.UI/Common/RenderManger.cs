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

            if (treeNode.Childs.Count > 0)
            {
                foreach (var subNode in treeNode.Childs)
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