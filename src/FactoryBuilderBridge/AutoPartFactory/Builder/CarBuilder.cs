using AutoPartFactory.Factory;
using AutoPartFactory.Model;
using AutoPartFactory.Model.Cars;

namespace AutoPartFactory.Builder
{
    public class CarBuilder : IVehicleBuilder<CarBuilder>
    {
        private readonly Car _car = new();
        private readonly IChassisFactory _chassisFactory;
        private readonly IDashboardFactory _dashboardFactory;
        private readonly IFrontEndFactory _frontEndFactory;

        public CarBuilder(IChassisFactory chassisFactory, IDashboardFactory dashboardFactory, IFrontEndFactory frontEndFactory)
        {
            _chassisFactory = chassisFactory;
            _dashboardFactory = dashboardFactory;
            _frontEndFactory = frontEndFactory;
        }

        public Car Build() => _car;

        public CarBuilder WithChassis()
        {
            _car.Chassis = _chassisFactory.Create<CarChassis>();
            _car.Chassis.PrintModel();

            return this;
        }

        public CarBuilder WithDashboard(bool withAirConditioningControl)
        {
            _car.Dashboard = _dashboardFactory.Create<CarDashboard>(withAirConditioningControl);
            _car.Dashboard.PrintModel();

            return this;
        }

        public CarBuilder WithFrontEnd(SteeringType steeringType)
        {
            _car.FrontEnd = _frontEndFactory.Create<CarFrontEnd>(steeringType);
            _car.FrontEnd.PrintModel();

            return this;
        }
    }
}