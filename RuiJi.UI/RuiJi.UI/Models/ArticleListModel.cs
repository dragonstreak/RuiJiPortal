using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuiJi.Web.MvcBase;

namespace RuiJi.UI.Models
{
    public class ArticleListModel : BaseModel
    {
        public List<ArticleModel> Articles { get; set; }

        public int TotalCount { get; set; }

        public int TotalPageCount
        {
            get
            {
                return (int)Math.Ceiling(TotalCount / (double)PageSize);
            }
        }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}