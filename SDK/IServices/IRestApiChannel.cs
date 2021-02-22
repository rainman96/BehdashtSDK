using Ditas.SDK.Services;

namespace Ditas.SDK.IServices
{
    internal interface IRestApiChannel
    {
        string CallWebApi(ApiHeader header, ApiRequest apiRequest);
    }

}