using RestSharp;
using Ditas.SDK.IServices;

namespace Ditas.SDK.Services
{
    internal class ApiHeader : IValidation
    {
        internal  string ClientId { get; set; } = AppConfiguration.OAUTH_CLIENTID;
        internal  string SecretId { get; set; } = AppConfiguration.OAUTH_SECRET;

        internal ApiHeader(string packageId,string apiUrl,int apiMethodType=1,string contentType= "application/json")
        {
            PackageID = packageId;
            ApiUrl = apiUrl;
            ApiMethodType = (Method)apiMethodType;
            ContentType = contentType;
        }
        internal string PackageID { get;  set; }
        internal Method ApiMethodType { get;  set; } = Method.POST;
        internal string ContentType { get;  set; }
        internal string ApiUrl { get;  set; }

        public (bool State, string Message, string FieldName) IsValid()
        {
            if (string.IsNullOrEmpty(PackageID))
                return (false, "value is null or empty", nameof(PackageID));
            if (string.IsNullOrEmpty(ApiUrl))
                return (false, "value is null or empty", nameof(ApiUrl));
            return (true, "", "");
        }
  
    }
}