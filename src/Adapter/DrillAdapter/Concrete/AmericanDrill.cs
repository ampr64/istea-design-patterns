using DrillAdapter.Abstract;
using System;

namespace DrillAdapter.Concrete
{
    public class AmericanDrill
    {
        private readonly IAmericanPlug _plug;

        public AmericanDrill(IAmericanPlug plug) => _plug = plug;

        public void TurnOn() => Console.WriteLine($"American drill be drillin' at {_plug.Voltage}V.");
    }
}