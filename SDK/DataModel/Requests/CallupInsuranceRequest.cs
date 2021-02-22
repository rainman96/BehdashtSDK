using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ditas.SDK.DataModel;
using Ditas.SDK.Helper;
using Ditas.SDK.IServices;
using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{

    public class InsuranceInquiryRequest:IJsonProducer
    {
        [JsonProperty("personID")]
        public DO_IDENTIFIER PersonID { get; set; }
        [JsonProperty("orgID")]
        public DO_IDENTIFIER OrgID { get; set; }
        [JsonProperty("hcpID")]
        public DO_IDENTIFIER HcpID { get; set; }
        [JsonProperty("ClientIp")]
        public string ClientIp { get; set; }
        [JsonProperty("appUser")]
        public string AppUser { get; set; }
        [JsonProperty("forceUpdate")]
        public string ForceUpdate { get; set; }

        public string ToJson()
        {
            return Utilities.ToJson(this);
        }
    }







}
