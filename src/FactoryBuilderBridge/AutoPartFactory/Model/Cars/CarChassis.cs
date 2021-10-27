using System;

namespace AutoPartFactory.Model.Cars
{
    public class CarChassis : IChassis
    {
        public int WheelCount { get; }

        public CarChassis(int wheelCount) => WheelCount = wheelCount;

        public void PrintModel() => Console.WriteLine($"Car chassis with {WheelCount} wheels");
    }
}