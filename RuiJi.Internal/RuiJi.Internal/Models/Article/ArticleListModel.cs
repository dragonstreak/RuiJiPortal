using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuiJi.Internal.Extensions;

namespace RuiJi.Internal.Models
{
    public class ArticleListModel : BaseModel
    {
        public ArticleListModel()
        {
            ArticleCategoryList = ArticleCategoryExtension.GetAllArticleCategory();
            PublishOption = new List<SimpleDDLItemModel<string, int>>() 
                                { 
                                    new SimpleDDLItemModel<string,int>()
                                    { 
                                        Name = "--All--",
                                        Value = -1},
                                    new SimpleDDLItemModel<string,int>()
                                     {
                                        Name = "Yes",
                                        Value = 1},
                                    new SimpleDDLItemModel<string,int>()
                                    {
                                        Name = "No",
                                        Value = 0}
                                };
            IsPublishedQry = -1;
        }

        public List<ArticleCategoryItemModel> ArticleCategoryList { get; set; }
        public int ArticleCategoryIdQry { get; set; }
        public string TitleQry { get; set; }
        public int IsPublishedQry { get; set; }
        public List<SimpleDDLItemModel<string,int>> PublishOption { get; set; }
        public List<ArticleItemModel> ArticleList { get; set; }
    }
}