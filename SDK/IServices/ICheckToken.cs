namespace Ditas.SDK.IServices
{
    internal interface ICheckToken
    {
        IRestApiChannel GetToken();
    }
    internal interface IServiceConfiguration
    {
        ICheckToken CheckConfiguration();
    }
  
}