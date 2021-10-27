using AutoPartFactory.Factory;
using AutoPartFactory.Model;
using AutoPartFactory.Model.Trucks;

namespace AutoPartFactory.Builder
{
    public class TruckBuilder : IVehicleBuilder<TruckBuilder>
    {
        private readonly Truck _truck = new();
        private readonly IChassisFactory _chassisFactory;
        private readonly IDashboardFactory _dashboardFactory;
        private readonly IFrontEndFactory _frontEndFactory;

        public TruckBuilder(IChassisFactory chassisFactory, IDashboardFactory dashboardFactory, IFrontEndFactory frontEndFactory)
        {
            _chassisFactory = chassisFactory;
            _dashboardFactory = dashboardFactory;
            _frontEndFactory = frontEndFactory;
        }

        public Truck Build() => _truck;

        public TruckBuilder WithChassis()
        {
            _truck.Chassis = _chassisFactory.Create<TruckChassis>();
            _truck.Chassis.PrintModel();

            return this;
        }

        public TruckBuilder WithDashboard(bool withAirConditioningControl)
        {
            _truck.Dashboard = _dashboardFactory.Create<TruckDashboard>(withAirConditioningControl);
            _truck.Dashboard.PrintModel();

            return this;
        }

        public TruckBuilder WithFrontEnd(SteeringType steeringType)
        {
            _truck.FrontEnd = _frontEndFactory.Create<TruckFrontEnd>(steeringType);
            _truck.FrontEnd.PrintModel();

            return this;
        }
    }
}