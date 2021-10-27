using System;

namespace AutoPartFactory.Model.Trucks
{
    public class TruckFrontEnd : IFrontEnd
    {
        public SteeringType SteeringType { get; }

        public TruckFrontEnd(SteeringType steeringType) => SteeringType = steeringType;

        public void PrintModel() => Console.WriteLine($"Truck front end with {$"{SteeringType}".ToLower()} steering.");
    }
}