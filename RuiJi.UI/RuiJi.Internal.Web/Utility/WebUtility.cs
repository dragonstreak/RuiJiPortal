using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuiJi.Internal.Web.Utility
{
    public class WebUtility
    {
        public static bool TryGetFileExtension(Uri url, ref string extension_out)
        {
            string str = null;
            int num = 0;
            str = url.Segments[url.Segments.Length - 1];
            num = str.LastIndexOf(".");
            if ((num <= 0) && (url.Segments.Length > 1))
            {
                str = url.Segments[url.Segments.Length - 2];
                str = str.Substring(0, str.Length - 1);
                num = str.LastIndexOf(".");
            }
            if (num > 0)
            {
                extension_out = str.Substring(num + 1, (str.Length - num) - 1).ToLowerInvariant();
                return true;
            }
            extension_out = null;
            return false;
        }
    }
}
