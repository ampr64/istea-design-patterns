using AutoPartFactory.Model;

namespace AutoPartFactory.Factory
{
    public interface IChassisFactory : IAutoPartFactory<IChassis>
    {
        TChassis Create<TChassis>() where TChassis : IChassis;
    }
}