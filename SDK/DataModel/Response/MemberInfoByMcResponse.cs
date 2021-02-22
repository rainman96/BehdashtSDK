using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{
    public class MemberInfoByMcResponse
    {
        [JsonProperty("Status")]
        public string[] Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("ReturnValue")]
        public MemberInfo ReturnValue { get; set; }
    }

    public class MemberInfo
    {
        [JsonProperty("LastSpecialityTitle")]
        public string LastSpecialityTitle { get; set; }
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("McCode")]
        public string McCode { get; set; }
        [JsonProperty("SpecialityCodes")]
        public string[] SpecialityCodes { get; set; }
    }
}
