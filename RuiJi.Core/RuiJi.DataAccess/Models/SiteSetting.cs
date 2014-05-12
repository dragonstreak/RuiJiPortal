using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RuiJi.DataAccess.Models
{
    public partial class SiteSetting
    {
        public int SiteSettingId { get; set; }
        public string MasterCSSFile { get; set; }
        public Nullable<int> CSSVersion { get; set; }
    }
}
