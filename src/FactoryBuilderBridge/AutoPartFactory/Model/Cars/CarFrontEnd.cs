using System;

namespace AutoPartFactory.Model.Cars
{
    public class CarFrontEnd : IFrontEnd
    {
        public SteeringType SteeringType { get; }

        public CarFrontEnd(SteeringType steeringType) => SteeringType = steeringType;

        public void PrintModel() => Console.WriteLine($"Car front end with {$"{SteeringType}".ToLower()} steering.");
    }
}