using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.SiteSettings
{
    public interface ISiteSettingSvc
    {
        SiteSetting Load();
        void Update(SiteSetting setting);
    }
}
