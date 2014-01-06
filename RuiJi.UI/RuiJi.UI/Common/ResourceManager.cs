using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuiJi.UI.Resources;

namespace RuiJi.UI.Common
{
    public class ResourceManager
    {
        public static readonly ResourceManager Instance = new ResourceManager();

        public static string GetLocalizedString(string reskey)
        {
            if (string.IsNullOrEmpty(reskey))
            {
                return "Null or Empty";
            }

            try
            {
                return Resource.ResourceManager.GetString(reskey) ?? reskey;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}