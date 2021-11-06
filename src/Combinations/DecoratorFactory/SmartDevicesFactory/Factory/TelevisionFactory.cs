using SmartDevicesFactory.Decorator.Components;

namespace SmartDevicesFactory.Factory
{
    public class TelevisionFactory : IFactory<Television>
    {
        public T Create<T>() where T : Television, new() => new();
    }
}