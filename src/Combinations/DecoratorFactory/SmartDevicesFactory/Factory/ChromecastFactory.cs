using SmartDevicesFactory.Decorator.Decorators;

namespace SmartDevicesFactory.Factory
{
    public class ChromecastFactory : IFactory<Chromecast>
    {
        public T Create<T>() where T : Chromecast, new() => new();
    }
}