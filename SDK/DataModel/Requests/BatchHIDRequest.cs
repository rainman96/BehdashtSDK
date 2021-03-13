using Ditas.SDK.Helper;
using Ditas.SDK.IServices;
using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    public class BatchHIDRequest : IJsonProducer
    {
        [JsonProperty("OrgID")]
        public DO_IDENTIFIER OrgID { get; set; }

        [JsonProperty("InsurerID")]
        public DO_CODED_TEXT InsurerID { get; set; }

        [JsonProperty("ClientIp")]
        public string ClientIp { get; set; }

        [JsonProperty("AppUser")]
        public string AppUser { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }

        public string ToJson()
        {
            return Utilities.ToJson(this);

        }
    }






}
