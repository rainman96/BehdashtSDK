using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{
    public class BaseResponse
    {
        [JsonProperty("Code")]
        public int HttpCode { get; set; }
        [JsonProperty("Error")]
        public string Status { get; internal set; }
        [JsonProperty("Error_Description")]
        public string Message { get; internal set; }
    }
}
