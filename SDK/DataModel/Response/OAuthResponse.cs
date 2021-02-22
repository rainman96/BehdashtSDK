using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    internal class OAuthResponse : BaseResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; internal set; }

        [JsonProperty("token_type")]
        public string TokenType { get; internal set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; internal set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; internal set; }
    }
}
