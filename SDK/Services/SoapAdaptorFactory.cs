using Ditas.SDK.IServices;
using System.ServiceModel;

namespace Ditas.SDK.Services
{
    internal class SoapAdaptorFactory : IAdaptorFactory
    {
        public T GetWebServiceFactory<T>(string url)
        {
            EndpointAddress endpointAddress = new EndpointAddress(url);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<T> factory = new ChannelFactory<T>(binding, endpointAddress);
            return factory.CreateChannel();
        }
    }
}