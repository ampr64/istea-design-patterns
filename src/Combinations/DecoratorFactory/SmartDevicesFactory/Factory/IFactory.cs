namespace SmartDevicesFactory.Factory
{
    public interface IFactory<TBase>
    {
        T Create<T>() where T : TBase, new();
    }
}