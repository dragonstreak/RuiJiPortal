using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using RuiJi.DataAccess.SiteSettings;

namespace RuiJi.UI.Common
{
    public class ConfigManager
    {
        public static readonly ConfigManager Instance = new ConfigManager();

        public static string GetAppSettings(string key)
        {
            return WebConfigurationManager.AppSettings[key];
        }

        public string TrackingServiceUrl
        {
            get
            {
                return GetAppSettings(AppSettingsKey.TrackingServiceUrl);
            }
        }

        public static string GetMainStyleFilePath()
        {
            return string.Format("{0}?ver={1}",SiteSettingSvc.Current.MasterCSSFile,SiteSettingSvc.Current.CSSVersion);
        }
    }
}