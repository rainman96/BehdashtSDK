using Ditas.SDK.IServices;

namespace Ditas.SDK.Services
{
    internal class FactoryChannel
    {
        internal IServiceConfiguration GetChannel() => RestApiChannel.GetChannelFromConfig();
    }
}