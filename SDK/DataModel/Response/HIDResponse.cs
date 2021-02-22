using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{
    public class HIDResponse
    {
        [JsonProperty("data")]
        public DO_IDENTIFIER Data { get; set; }
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
        [JsonProperty("waitTime")]
        public int WaitTime { get; set; }
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
        [JsonProperty("message")]
        public string[] Message { get; set; }
    }
}
