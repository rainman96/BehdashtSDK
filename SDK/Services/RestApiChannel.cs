using Newtonsoft.Json;
using RestSharp;
using Ditas.SDK.DataModel;
using Ditas.SDK.IServices;
using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ditas.SDK.Services
{
    internal class RestApiChannel : IServiceConfiguration, ICheckToken, IRestApiChannel
    {

        private static TokenManager _tokenManager;

        public IRestResponse CallWebApi(ApiHeader header, ApiRequest apiRequest)
        {
            var (isValid, message, _) = ValidateInputs(header, apiRequest);
            if (isValid == false)
                throw new ArgumentException(message);
            if ((_tokenManager?.GetTokenState() ?? TokenManager.TokenState.Empty) == TokenManager.TokenState.Empty)
                throw new Exception("Token is empty");

            //Log.Debug($"Calling CallWebApiGet({address},data,method,token)");
            string _base = AppConfiguration.WebServiceBaseAddress;
            var client = new RestClient($"{(_base.EndsWith("/") ? _base : _base + "/")}{(header.ApiUrl.StartsWith("/") ? header.ApiUrl.Remove(0, 1) : header.ApiUrl)}");
            var request = new RestRequest(header.ApiMethodType);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", header.ContentType);
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Authorization", "bearer " + _tokenManager.GetAccessToken());
            request.AddHeader("pid", header.PackageID);
            request.AddJsonBody(apiRequest.JsonBody);
            IRestResponse response = client.Execute(request);
            return response;
        }
        public static IServiceConfiguration GetChannelFromConfig() => new RestApiChannel();
        public IRestApiChannel GetToken()
        {
            var state = TokenManager.TokenState.Empty;
            if (_tokenManager != null)
                state = _tokenManager.GetTokenState();
            switch (state)
            {
                case TokenManager.TokenState.Expired:
                case TokenManager.TokenState.Empty:
                    Interlocked.Exchange(ref _tokenManager, GetNewTokenByUsername());
                    break;
                case TokenManager.TokenState.NearExpire:
                    Interlocked.Exchange(ref _tokenManager, GetNewTokenByRefresh());
                    break;
                case TokenManager.TokenState.Ok:
                    break;
                default:
                    throw new NullReferenceException("The token is not in the predicted state");
            }
            return this;
        }

        public ICheckToken CheckConfiguration()
        {
            var state = AppConfiguration.IsValid();
            if (state.State)
                return this;
            throw new NullReferenceException(state.Message);
        }

        #region Private
        private (bool State, string Message, string FieldName) ValidateInputs(ApiHeader header, ApiRequest apiRequest)
        {
            var headerValidationresult = header.IsValid();
            if (!headerValidationresult.State)
                return headerValidationresult;

            var apiRequestValidationresult = apiRequest.IsValid();
            if (!apiRequestValidationresult.State)
                return apiRequestValidationresult;

            return (true, "", "");
        }
        private TokenManager GetNewTokenByRefresh()
        {
            GeneralResponse<OAuthResponse> res = RefreshToken();
            if (res.HttpCode == (int)HttpStatusCode.OK)
            {
                return new TokenManager(res.Model.AccessToken, res.Model.RefreshToken, res.Model.ExpiresIn);
            }
            else
                throw new Exception("Loggin failed...");
        }
        private TokenManager GetNewTokenByUsername()
        {
            GeneralResponse<OAuthResponse> res = LoginFromConfig();
            if (res.HttpCode == (int)HttpStatusCode.OK)
            {
                return new TokenManager(res.Model.AccessToken, res.Model.RefreshToken, res.Model.ExpiresIn);
            }
            else
                throw new Exception("Loggin failed...");
        }
        private GeneralResponse<OAuthResponse> LoginFromConfig()
        {
            string baseUrl = AppConfiguration.WebServiceBaseAddress;
            string url = AppConfiguration.LoginApiUrl;
            if (string.IsNullOrEmpty(baseUrl))
                throw new NullReferenceException("WebApiService address is empty");
            if (string.IsNullOrEmpty(AppConfiguration.LoginApiUrl))
                throw new NullReferenceException("Login api address is empty");

            var client = new RestClient($"{(baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/")}{(url.StartsWith("/") ? url.Remove(0, 1) : url)}");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            var req = (Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes($"{AppConfiguration.OAUTH_CLIENTID}:{AppConfiguration.OAUTH_SECRET}")));
            request.AddHeader("Authorization", "Basic " + req);
            request.AddParameter($"grant_type", "password");
            request.AddParameter($"username", $"{AppConfiguration.Username}");
            request.AddParameter($"password", $"{ AppConfiguration.Password}");
            IRestResponse response = client.Execute(request);
            var gResponse = new GeneralResponse<OAuthResponse>();
            if (response.StatusCode == HttpStatusCode.OK)
                gResponse.Model = JsonConvert.DeserializeObject<OAuthResponse>(response.Content);
            else
            {
                if (response.ErrorException != null) throw response.ErrorException;
                throw new Exception("Loggin failed");
            }
            gResponse.HttpCode = (int)response.StatusCode;
            return gResponse;
        }
        private GeneralResponse<OAuthResponse> RefreshToken()
        {
            string baseUrl = AppConfiguration.WebServiceBaseAddress;
            string url = AppConfiguration.LoginApiUrl;
            if (string.IsNullOrEmpty(baseUrl))
                throw new NullReferenceException("WebApiService address is empty");
            if (string.IsNullOrEmpty(AppConfiguration.LoginApiUrl))
                throw new NullReferenceException("Login api address is empty");

            var client = new RestClient($"{(baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/")}{(url.StartsWith("/") ? url.Remove(0, 1) : url)}");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            var req = (Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes($"{AppConfiguration.OAUTH_CLIENTID}:{AppConfiguration.OAUTH_SECRET}")));
            request.AddHeader("Authorization", "Basic " + req);
            request.AddParameter($"grant_type", "refresh_token");
            request.AddParameter($"refresh_token", $"{_tokenManager.GetRefreshToken()}");
            IRestResponse response = client.Execute(request);
            var gResponse = new GeneralResponse<OAuthResponse>();
            if (response.StatusCode == HttpStatusCode.OK)
                gResponse.Model = JsonConvert.DeserializeObject<OAuthResponse>(response.Content);
            else
            {
                if (response.ErrorException != null) throw response.ErrorException;
                throw new Exception("Loggin failed");
            }
            gResponse.HttpCode = (int)response.StatusCode;
            return gResponse;
        }
        private class TokenManager
        {
            private string Token { get; set; }
            private string RefreshToken { get; set; }
            private DateTime ExpireTime { get; set; }
            internal TokenManager(string token, string refreshToken, int expireIn)
            {
                Token = token;
                RefreshToken = refreshToken;
                ExpireTime = DateTime.Now.AddSeconds(expireIn);
            }
            internal enum TokenState
            {
                Empty = 0,
                NearExpire = 1,
                Expired = 2,
                Ok = 3

            }
            internal TokenState GetTokenState()
            {
                if (string.IsNullOrEmpty(Token)) return TokenState.Empty;
                var remainingTime = ExpireTime.Subtract(DateTime.Now).TotalSeconds;
                if (remainingTime < 10 && remainingTime > 0) return TokenState.NearExpire;
                if (remainingTime <= 0) return TokenState.Expired;
                return TokenState.Ok;
            }

            internal string GetAccessToken() => Token;
            internal string GetRefreshToken() => RefreshToken;
        }
        #endregion

    }
}