using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    public class GeneralResponse : BaseResponse
    {
        [JsonProperty("violations")]
        public string[] Violations { get; internal set; }
    }
    public class GeneralResponse<T> : BaseResponse
    {
        [JsonProperty("Model")]
        public T Model { get; internal set; }
        [JsonProperty("violations")]
        public string[] Violations { get; internal set; }
    }
}
