using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace RuiJi.Internal.Security
{
    public static class SecurityService
    {
        // Fields
        private const string Security_Key = "3t0wn_H@sh";

        // Methods
        private static string ComputeHash(byte[] buffer)
        {
            StringBuilder builder = new StringBuilder();
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            foreach (byte num in provider.ComputeHash(buffer))
            {
                builder.Append(num.ToString("x2"));
            }
            return builder.ToString();
        }

        public static string CreateSecurityToken(List<string> values)
        {
            return CreateSecurityToken(Security_Key, values);
        }

        public static string CreateSecurityToken(params string[] values)
        {
            return CreateSecurityTokenWithKey(Security_Key, values);
        }

        public static string CreateSecurityToken(string securityKey, List<string> values)
        {
            StringBuilder builder = new StringBuilder();
            values.Sort();
            foreach (string str in values)
            {
                builder.Append(str + ":");
            }
            builder.Append(securityKey);
            return ComputeHash(Encoding.UTF8.GetBytes(builder.ToString()));
        }

        public static string CreateSecurityTokenWithKey(string securityKey, params string[] values)
        {
            List<string> list = new List<string>(values);
            return CreateSecurityToken(securityKey, list);
        }

        public static bool IsValidToken(string token, DateTime utcTokenDate, TimeSpan tokenMaxAge, params string[] values)
        {
            return IsValidToken(Security_Key, token, utcTokenDate, tokenMaxAge, values);
        }

        public static bool IsValidToken(string securityKey, string token, DateTime utcTokenDate, TimeSpan tokenMaxAge, params string[] values)
        {
            if (DateTime.UtcNow.Subtract(utcTokenDate) > tokenMaxAge)
            {
                return false;
            }
            string b = CreateSecurityTokenWithKey(securityKey, values);
            return string.Equals(token, b, StringComparison.Ordinal);
        }

        public static string Md5Hash(string clearText)
        {
            return ComputeHash(Encoding.UTF8.GetBytes(clearText));
        }
    }

}