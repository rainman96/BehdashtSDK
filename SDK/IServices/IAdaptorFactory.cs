namespace Ditas.SDK.IServices
{
    internal interface IAdaptorFactory
    {
        T GetWebServiceFactory<T>(string url="") /* where T:new()*/;
    }
}