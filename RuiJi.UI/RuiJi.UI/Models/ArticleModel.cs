﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuiJi.UI.Models
{
    public class ArticleModel
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string ContentDetail { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
    }
}