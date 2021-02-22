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

    public class HIDRequest : IJsonProducer
    {
        [JsonProperty("PersonID")]
        public DO_IDENTIFIER PersonID { get; set; }

        [JsonProperty("OrgID")]
        public DO_IDENTIFIER OrgID { get; set; }

        [JsonProperty("HcpID")]
        public DO_IDENTIFIER HcpID { get; set; }

        [JsonProperty("InsurerID")]
        public DO_CODED_TEXT InsurerID { get; set; }

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
