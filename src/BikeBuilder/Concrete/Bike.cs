using BikeBuilder.Abstract;
using System;

namespace BikeBuilder.Concrete
{
    public class Bike
    {
        public IHandlebar Handlebar { get; internal set; }

        public IBikeFrame Frame { get; internal set; }

        public IWheel Wheel { get; internal set; }

        public void DisplayBikeInfo() => Console.WriteLine($"This bike has the following parts:\n- {Handlebar.Name}\n- {Frame.Name}\n- {Wheel.Name}");
    }
}