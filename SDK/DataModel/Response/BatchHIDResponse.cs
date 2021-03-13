using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    public class BatchHIDResponse
    {
        [JsonProperty("data")]
        public DO_CODED_TEXT Data { get; set; }
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
