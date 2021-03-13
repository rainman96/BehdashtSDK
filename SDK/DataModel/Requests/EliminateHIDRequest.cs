using Ditas.SDK.Helper;
using Ditas.SDK.IServices;
using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    public class EliminateHIDRequest : IJsonProducer
    {
        [JsonProperty("PersonID")]
        public DO_IDENTIFIER PersonID { get; set; }

        [JsonProperty("OrgID")]
        public DO_IDENTIFIER OrgID { get; set; }

        [JsonProperty("Reason")]
        public DO_CODED_TEXT Reason { get; set; }

        [JsonProperty("HID")]
        public DO_IDENTIFIER HID { get; set; }

        [JsonProperty("ClientIp")]
        public string ClientIp { get; set; }

        [JsonProperty("AppUser")]
        public string AppUser { get; set; }
        public string ToJson()
        {
            return Utilities.ToJson(this);

        }
    }
    

}
