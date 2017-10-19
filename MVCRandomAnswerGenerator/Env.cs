using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRandomAnswerGenerator
{
    public class Env
    {
        private static Dictionary<string, string> _Values = new Dictionary<string, string>();
        public static string Version => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public static string CustomerName => Get("CM_CUSTOMER_NAME");
        public static string LogoUrl => Get("CM_LOGO_URL");
        public static string DbName => Get("CM_DATABASE_NAME");

        private static string Get(string variable)
        {
            if (!_Values.ContainsKey(variable))
            {
                var value = Environment.GetEnvironmentVariable(variable);
                _Values[variable] = value;
            }
            return _Values[variable];
        }

    }
}