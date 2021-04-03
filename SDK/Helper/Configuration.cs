using Ditas.SDK.IServices;
using System;
using System.Configuration;

namespace Ditas.SDK
{
    internal static class AppConfiguration
    {
        private static bool ConfigurationIsValid = false;
        internal static string LocationID => ConfigurationManager.AppSettings[Constants.ConstatKeyValues.LOCATION_ID] ?? throw new SdkException($"{Constants.ConstatKeyValues.LOCATION_ID} Not found in configuration file");
        internal static string SystemId => ConfigurationManager.AppSettings[Constants.ConstatKeyValues.SYSTEM_ID] ?? throw new SdkException($"{Constants.ConstatKeyValues.SYSTEM_ID} Not found in configuration file");

        internal static string WebServiceBaseAddress => ConfigurationManager.AppSettings[Constants.ConstatKeyValues.WEBSERVICE_BASE_URL] ?? throw new SdkException($"{Constants.ConstatKeyValues.WEBSERVICE_BASE_URL} Not found in configuration file");
        internal static string PID(string key)
        {

            var value = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrEmpty(value))
                throw new SdkException($"{key} Not found in configuration file");
            return value;
        }
        public static (bool State, string Message, string FieldName) IsValid()
        {
            if (ConfigurationIsValid) return (ConfigurationIsValid, "", "");
            var fieldname = "";
            if (string.IsNullOrEmpty(WebServiceBaseAddress))
            {
                fieldname = nameof(WebServiceBaseAddress);
                ConfigurationIsValid = false;
            }
            if (string.IsNullOrEmpty(OAUTH_CLIENTID))
            {
                fieldname = nameof(OAUTH_CLIENTID);
                ConfigurationIsValid = false;
            }
            if (string.IsNullOrEmpty(OAUTH_SECRET))
            {
                fieldname = nameof(OAUTH_SECRET);
                ConfigurationIsValid = false;
            }
            if (string.IsNullOrEmpty(LoginApiUrl))
            {
                fieldname = nameof(LoginApiUrl);
                ConfigurationIsValid = false;
            }
            if (string.IsNullOrEmpty(Username))
            {
                fieldname = nameof(Username);
                ConfigurationIsValid = false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                fieldname = nameof(Password);
                ConfigurationIsValid = false;
            }
            if (string.IsNullOrEmpty(LocationID))
            {
                fieldname = nameof(LocationID);
                ConfigurationIsValid = false;
            }

            else ConfigurationIsValid = true;

            return ConfigurationIsValid ? (true, "", "") : (false, $"{fieldname} is null or empty", fieldname);
        }

        internal static string OAUTH_CLIENTID => ConfigurationManager.AppSettings[Constants.ConstatKeyValues.CLIENT_ID] ?? throw new SdkException($"{Constants.ConstatKeyValues.CLIENT_ID} Not found in configuration file");
        internal static string OAUTH_SECRET => ConfigurationManager.AppSettings[Constants.ConstatKeyValues.SECRET_ID] ?? throw new SdkException($"{Constants.ConstatKeyValues.SECRET_ID} Not found in configuration file");
        internal static string LoginApiUrl => ConfigurationManager.AppSettings[Constants.ConstatKeyValues.OAUTH_SERVICE_URL] ?? throw new SdkException($"{Constants.ConstatKeyValues.OAUTH_SERVICE_URL} Not found in configuration file");
        internal static string Username => ConfigurationManager.AppSettings[Constants.ConstatKeyValues.API_USERNAME] ?? throw new SdkException($"{Constants.ConstatKeyValues.API_USERNAME} Not found in configuration file");
        internal static string Password => ConfigurationManager.AppSettings[Constants.ConstatKeyValues.API_PASSWORD] ?? throw new SdkException($"{Constants.ConstatKeyValues.API_PASSWORD} Not found in configuration file");
        internal static bool ActiveLog => (ConfigurationManager.AppSettings[Constants.ConstatKeyValues.USE_LOG] ?? "false").ToLowerInvariant() != "false";
        internal static string AbsolutePublicKeyFileName = ConfigurationManager.AppSettings[Constants.ConstatKeyValues.ABSOLUTE_PUBLIC_KEY_FILE_PATH] ?? throw new SdkException($"{Constants.ConstatKeyValues.ABSOLUTE_PUBLIC_KEY_FILE_PATH} Not found in configuration file");

    }

    internal class Configuration
    {
        internal static CenterMode Center_Mode()
        {
            return (CenterMode)int.Parse(ConfigurationManager.AppSettings["CenterMode"]);

            /* TODO ERROR: Skipped IfDirectiveTrivia */
            /* TODO ERROR: Skipped DisabledTextTrivia */
            /* TODO ERROR: Skipped EndIfDirectiveTrivia */
            /* TODO ERROR: Skipped IfDirectiveTrivia */
            /* TODO ERROR: Skipped DisabledTextTrivia */
            /* TODO ERROR: Skipped EndIfDirectiveTrivia */
            /* TODO ERROR: Skipped IfDirectiveTrivia */
            throw new Exception("Error at Center_Mode.");
        }
        internal enum CenterMode
        {
            MultiCenteric = 1,
            UniCentric = 2
        }
    }
}