using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;
using RuiJi.DataAccess.SiteSettings.Data;

namespace RuiJi.DataAccess.SiteSettings
{
    public class SiteSettingSvc : ISiteSettingSvc
    {
        private ISiteSettingMgr _mgr;

        public SiteSettingSvc(ISiteSettingMgr mgr)
        {
            _mgr = mgr;
        }

        public SiteSetting Load()
        {
            return _mgr.Load();
        }

        public void Update(SiteSetting setting)
        {
            _mgr.Update(setting);
        }

        private static SiteSetting _current;
        public static SiteSetting Current
        {
            get
            {
                if (_current == null)
                {
                    ISiteSettingMgr innerMgr = new SiteSettingMgr();
                    _current = innerMgr.Load();
                }

                return _current;
            }
        }

        public static void Refresh()
        {
            _current = null;
        }
    }
}
