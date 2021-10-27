using AutoPartFactory.Model;

namespace AutoPartFactory.Builder
{
    public interface IVehicleBuilder<TBuilder> where TBuilder : IVehicleBuilder<TBuilder>
    {
        TBuilder WithChassis();

        TBuilder WithDashboard(bool withAirConditioningControl);

        TBuilder WithFrontEnd(SteeringType steeringType);
    }
}