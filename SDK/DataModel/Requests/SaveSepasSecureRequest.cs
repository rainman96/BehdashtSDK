using Ditas.SDK.Helper;
using Ditas.SDK.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{

    public class SaveSepasSecureRequest : IJsonProducer
    {
        [JsonProperty("IPClient")]
        public string IPClient { get; set; }
        [JsonProperty("IPServer")]
        public string IPServer { get; set; }
        [JsonProperty("SystemID")]
        public string SystemID { get; set; }
        [JsonProperty("LocationID")]
        public string LocationID { get; set; }
        [JsonProperty("ContentType")]
        public string ContentType { get; set; }
        [JsonProperty("Data")]
        public string Data { get; set; }
        [JsonProperty("Key")]
        public string Key { get; set; }
        [JsonProperty("IV")]
        public string IV { get; set; }

        public string ToJson()
        {
            return Utilities.ToJson(this);
        }
    }

 

 

}
