using System;

namespace AutoPartFactory.Model.Trucks
{
    public class TruckDashboard : IDashboard
    {
        public bool HasAirConditioning { get; }

        public TruckDashboard(bool hasAirConditioningControl) => HasAirConditioning = hasAirConditioningControl;

        public void PrintModel() => Console.WriteLine($"Truck dashboard {(HasAirConditioning ? "with" : "without")} air conditioning.");
    }
}