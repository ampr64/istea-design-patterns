using AutoPartFactory.Model;

namespace AutoPartFactory.Factory
{
    public interface IFrontEndFactory
    {
        TFrontEnd Create<TFrontEnd>(SteeringType steeringType);
    }
}