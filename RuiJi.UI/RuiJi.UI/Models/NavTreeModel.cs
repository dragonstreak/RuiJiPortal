using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuiJi.UI.Models
{
    public class NavTreeModel : NavTreeNodeModel
    {
        public NavTreeModel()
        {
            // TODO: lazy load
            this.Childs = this.LoadTree();
        }



        private List<NavTreeNodeModel> LoadTree()
        {
            return null;
        }
    }
}