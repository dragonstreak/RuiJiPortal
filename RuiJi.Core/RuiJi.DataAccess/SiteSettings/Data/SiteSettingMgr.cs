using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.SiteSettings.Data
{
    internal class SiteSettingMgr : ISiteSettingMgr
    {
        private const int SiteSettingId = 1;

        public SiteSetting Load()
        {
            using (var db = new RuijiPortalContext())
            {
                return db.SiteSettings.Find(SiteSettingId);
            }
        }

        public void Update(SiteSetting setting)
        {
            using (var db = new RuijiPortalContext())
            {
                db.Entry(setting).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
