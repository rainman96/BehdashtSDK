using Ditas.SDK.Services;
using RestSharp;

namespace Ditas.SDK.IServices
{
    internal interface IRestApiChannel
    {
        IRestResponse CallWebApi(ApiHeader header, ApiRequest apiRequest);
    }

}