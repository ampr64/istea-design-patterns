using System;

namespace AutoPartFactory.Model.Cars
{
    public class CarDashboard : IDashboard
    {
        public bool HasAirConditioning { get; }

        public CarDashboard(bool hasAirConditioningControl) => HasAirConditioning = hasAirConditioningControl;

        public void PrintModel() => Console.WriteLine($"Car dashboard {(HasAirConditioning ? "with" : "without")} air conditioning control.");
    }
}