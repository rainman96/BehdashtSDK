using log4net;
using Newtonsoft.Json.Linq;
using Ditas.SDK.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ditas.SDK
{
    public sealed partial class Service
    {
        //private URL Urls;
        private ILog Log = LogManager.GetLogger(nameof(Service));
        //private string ToJsonRequest<T>(T secureRequest)
        //{
        //    return Newtonsoft.Json.JsonConvert.SerializeObject(secureRequest);
        //}

        private T ConvertToModel<T>(string result, params string[] filters)
        {
            JObject googleSearch = JObject.Parse(result);
            JToken results = googleSearch["result"]["data"];
            foreach (var filter in filters)
            {
                results = results[filter];
            }
            // get JSON result objects into a list

            // serialize JSON results into .NET objects
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

        private void _LogIfAvailiable(string msg)
        {
            if (AppConfiguration.ActiveLog)
            {
                var text = string.Empty;
                Log.Info($"{ DateTime.Now.ToString("yyyy / MM / dd HH: mm:ss.fff")} | {msg }");
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

                _LogIfAvailiable("...Get HealthCareFacility");
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
