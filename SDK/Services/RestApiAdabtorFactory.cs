using Ditas.SDK.IServices;
using System;

namespace Ditas.SDK.Services
{
    internal class RestApiAdabtorFactory : IAdaptorFactory
    {
        public T GetWebServiceFactory<T>(string url="")
        {
            // Type type = typeof(T);
            //return (T)Activator.CreateInstance(type, url);
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}