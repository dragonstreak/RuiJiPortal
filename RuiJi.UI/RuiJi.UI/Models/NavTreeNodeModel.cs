using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuiJi.UI.Models
{
    public class NavTreeNodeModel
    {
        public NavTreeNodeModel()
        {
            this.Children = new List<NavTreeNodeModel>();
        }

        public List<NavTreeNodeModel> Children { get; set; }

        public bool IsCurrent { get; set; }

        public bool IsSubTopLevel { get; set; }

        public bool IsTopLevel { get; set; }

        public string ResourceKey { get; set; }

        public int CategoryId { get; set; }

		public string Name { get; set; }

        public int HomePageDisplayOrder { get; set; }
    }
}