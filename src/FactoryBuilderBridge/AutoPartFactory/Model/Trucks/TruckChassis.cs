using System;

namespace AutoPartFactory.Model.Trucks
{
    public class TruckChassis : IChassis
    {
        public int WheelCount { get; }

        public TruckChassis(int wheelCount) => WheelCount = wheelCount;

        public void PrintModel() => Console.WriteLine($"Truck chassis with {WheelCount} wheels");
    }
}