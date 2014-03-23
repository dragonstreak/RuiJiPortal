using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuiJi.Internal.Models;

namespace RuiJi.Internal.Models
{
    public class ArticleCategoryListModel : BaseModel
    {

        public List<ArticleCategoryItemModel> ArticleCategoryList { get; set; }
    }
}