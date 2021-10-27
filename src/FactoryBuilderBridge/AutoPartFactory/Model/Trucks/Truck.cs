namespace AutoPartFactory.Model.Trucks
{
    public class Truck : IVehicle<TruckChassis, TruckDashboard, TruckFrontEnd>
    {
        public TruckChassis Chassis { get; set; }

        public TruckDashboard Dashboard { get; set; }

        public TruckFrontEnd FrontEnd { get; set; }
    }
}