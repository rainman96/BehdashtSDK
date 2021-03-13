using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    internal class EliminateHIDResponse
    {
        [JsonProperty("data")]
        internal bool Data { get; set; }
        [JsonProperty("isSuccess")]
        internal bool IsSuccess { get; set; }
        [JsonProperty("waitTime")]
        internal int WaitTime { get; set; }
        [JsonProperty("statusCode")]
        internal int StatusCode { get; set; }
        [JsonProperty("message")]
        internal string[] Message { get; set; }
    }
    internal class UpdateHIDResponse
    {
        [JsonProperty("data")]
        internal bool Data { get; set; }
        [JsonProperty("isSuccess")]
        internal bool IsSuccess { get; set; }
        [JsonProperty("waitTime")]
        internal int WaitTime { get; set; }
        [JsonProperty("statusCode")]
        internal int StatusCode { get; set; }
        [JsonProperty("message")]
        internal string[] Message { get; set; }
    }
}
