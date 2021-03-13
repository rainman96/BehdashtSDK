using log4net;
using Newtonsoft.Json.Linq;
using Ditas.SDK.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using static Ditas.SDK.Constants.Enumarations;

namespace Ditas.SDK
{
    public sealed partial class Service
    {
        //private URL Urls;
        private static ILog Log = LogManager.GetLogger(nameof(Service));
        //private string ToJsonRequest<T>(T secureRequest)
        //{
        //    return Newtonsoft.Json.JsonConvert.SerializeObject(secureRequest);
        //}

        private T ConvertToModel<T>(string result, params string[] filters)
        {
            if (string.IsNullOrEmpty(result)) return default;
            JObject googleSearch = JObject.Parse(result);
            JToken results = googleSearch["result"]["data"];
            foreach (var filter in filters)
            {
                results = results[filter];
            }
            // get JSON result objects into a list

            // serialize JSON results into .NET objects
            if (results == null)
                return default;
            T searchResult = results.ToObject<T>();
            return searchResult;
        }

        private string ToQueryString(Dictionary<string, string> paramerters)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in paramerters)
            {
                sb.Append(item.Key).Append("/").Append(item.Value);
            }
            return sb.ToString();
        }

        private void _LogIfAvailiable(string msg,LogLevel logLevel=LogLevel.Info)
        {
            if (AppConfiguration.ActiveLog)
            {
                switch (logLevel)
                {
                    case LogLevel.Info:
                        Log.Info(msg);
                        break;
                    case LogLevel.Warn:
                        Log.Warn(msg);
                        break;
                    case LogLevel.Debug:
                        Log.Debug(msg);
                        break;
                    case LogLevel.Error:
                        Log.Error(msg);
                        break;
                    case LogLevel.Fatal:
                        Log.Fatal(msg);
                        break;
                    case LogLevel.All:
                        Log.Info(msg);
                        break;
                    case LogLevel.Off:
                    default:
                        break;
                }
            }
        }
 
        private (bool State, string Message, string Filed) IsValid(params (string Filed, string Value)[] reqData)
        {
            for (int i = 0; i < reqData.Length; i++)
            {
                if (string.IsNullOrEmpty(reqData[i].Value))
                    return (false, "value is null or empty", reqData[i].Filed);
            }
            return (true, "", "");
        }
        internal DO_IDENTIFIER GetHealthCareFacility()
        {
            try
            {
                var healthcarefacility = new DO_IDENTIFIER();
                healthcarefacility.Issuer = "MOHME_IT";
                healthcarefacility.ID = AppConfiguration.LocationID;
                healthcarefacility.Assigner = "MOHME_IT";
                healthcarefacility.Type = "Org_ID";

                _LogIfAvailiable("Get HealthCareFacility...");
                return healthcarefacility;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                throw new Exception("Error at GetHealthCareFacility. ", ex);
            }
        }
    }
}
