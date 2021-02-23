using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{
    internal class CallUpFailedResponse
    {
        [JsonProperty("isSuccess")]
        internal bool isSuccess { get; set; }
        [JsonProperty("waitTime")]
        internal int waitTime { get; set; }
        [JsonProperty("statusCode")]
        internal int statusCode { get; set; }
        [JsonProperty("message")]
        internal string[] message { get; set; }
    }
}
