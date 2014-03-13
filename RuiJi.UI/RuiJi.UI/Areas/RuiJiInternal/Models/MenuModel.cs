using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuiJi.Internal.Models
{
	public class MenuModel
	{
		public int Id { get; set; }
		public int ParentId { get; set; }
		public int Type {get; set;}
		public string Name { get; set; }
		public string DisplayName { get; set; }
		public int SortIndex { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
		public string Target { get; set; }
		public string Tooltip { get; set; }
        public string ClickAction { get; set; }
		public List<MenuModel> SubMenus { get; set; }
        		
		private List<string> permissionCodes = new List<string>();
		public List<string> PermissionCodes
		{
			get
			{
				return permissionCodes;
			}
			set
			{
				permissionCodes = value;
			}
		}
	}
}