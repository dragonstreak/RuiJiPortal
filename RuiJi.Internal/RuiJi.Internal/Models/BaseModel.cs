using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuiJi.Internal.Models
{
    public class BaseModel
    {
        public string CurrentMenu { get; set; }

        public string CurrentSubMenu { get; set; }

        private int pageScroll = 0;
        public int PageScroll
        {
            get
            {
                return pageScroll;
            }
            set
            {
                pageScroll = value;
            }
        }

        private string pageMessage = string.Empty;
        public string PageMessage
        {
            get { return pageMessage; }
            set { pageMessage = value; }
        }

        public void SetMenu(string menu, string subMenu)
        {
            this.CurrentMenu = menu;
            this.CurrentSubMenu = subMenu;
        }
    }
}