using Ditas.SDK.Helper;
using Ditas.SDK.IServices;
using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    public class VerifyHIDRequest : IJsonProducer
    {
        [JsonProperty("PersonID")]
        public DO_IDENTIFIER PersonID { get; set; }

        [JsonProperty("OrgID")]
        public DO_IDENTIFIER OrgID { get; set; }

        [JsonProperty("ClientIp")]
        public string ClientIp { get; set; }

        [JsonProperty("HID")]
        public DO_IDENTIFIER HID { get; set; }

        [JsonProperty("AppUser")]
        public string AppUser { get; set; }
        public string ToJson()
        {
            return Utilities.ToJson(this);

        }
    }
    

}
