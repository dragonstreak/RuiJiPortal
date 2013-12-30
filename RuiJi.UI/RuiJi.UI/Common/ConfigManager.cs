using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace RuiJi.UI.Common
{
    public class ConfigManager
    {
        public static readonly ConfigManager Instance = new ConfigManager();

        public static string GetAppSettings(string key)
        {
            return WebConfigurationManager.AppSettings[key];
        }

        public string ForumUrl
        {
            get
            {
                return GetAppSettings(AppSettingsKey.ForumUrl);
            }
        }
    }
}