using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using RuiJi.Internal.Context;
using RuiJi.Internal.Security;

namespace RuiJi.Internal.Common
{
    internal class RuiJiContextCookieSerializer
    {
        private const string MainDelimiter = "$";
        private const string Delimiter = "|";
        private const char ListDelimiter = ',';

        public static string Serialize(RuiJiContext context)
        {
            if (context == null)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();

            sb.Append(context.UserId);
            sb.Append(Delimiter);

            sb.Append(context.UserName);
            sb.Append(Delimiter);
            var roleList = string.Join(ListDelimiter.ToString(), context.Roles);
            sb.Append(roleList);

            var tokenCreateDate = DateTime.UtcNow;
            var token = SecurityService.CreateSecurityToken(new string[] { sb.ToString() });

            var serialized = string.Format("{0}{3}{1}{3}{2}", sb.ToString(), token, tokenCreateDate.ToString("yyyy-MM-dd HH:mm:ss"), MainDelimiter);

            return serialized;
        }

        public static bool TryDeserialize(
            string cookieText
            , out RuiJiContext context)
        {
            string[] mainValues = cookieText.Split(new[] { MainDelimiter }, StringSplitOptions.None);
            if (mainValues.Length != 3)
            {
                context = null;

                return false;
            }

            var userInfo = mainValues[0];
            var token = mainValues[1];
            DateTime tokenDate;
            if (!DateTime.TryParse(mainValues[2], out tokenDate))
            {
                context = null;

                return false;
            }

            if (!SecurityService.IsValidToken(token, tokenDate, new TimeSpan(24, 0, 0), userInfo))
            {
                context = null;
                //throw new Exception("Oboe User Cookie deserialize error:" + cookieText)
                return false;
            }

            var values = userInfo.Split(new[] { Delimiter }, StringSplitOptions.None);

            try
            {
                if (values.Length != 3)
                {
                    context = null;
                    //throw new Exception("Oboe User Cookie deserialize error:" + cookieText));

                    return false;
                }

                // user_id
                var UserId = int.Parse(values[0]);

                // login name
                string loginName = values[1];

                List<string> roles = values[2].Split(ListDelimiter).ToList();

                context = new RuiJiContext(UserId, loginName, roles);

                return true;
            }
            catch
            {
                context = null;
                //throw new Exception("Oboe User Cookie deserialize error:" + cookieText, ex);

                return false;
            }
        }
    }
}