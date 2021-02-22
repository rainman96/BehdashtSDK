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
    class MemberInfoByMcRequest:IJsonProducer
    {
        [JsonProperty("mcCodeNumeric")]
        public string McCodeNumeric { get; set; }
        [JsonProperty("mcCodeTypeEn")]
        public string McCodeTypeEn { get; set; }
        public string ToJson()
        {
            return Utilities.ToJson(this);

        }
    }

}
