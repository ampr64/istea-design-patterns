namespace AutoPartFactory.Model.Cars
{
    public class Car : IVehicle<CarChassis, CarDashboard, CarFrontEnd>
    {
        public CarChassis Chassis { get; set; }

        public CarDashboard Dashboard { get; set; }

        public CarFrontEnd FrontEnd { get; set; }
    }
}