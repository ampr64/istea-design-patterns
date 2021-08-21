using DrillAdapter.Adapter;
using DrillAdapter.Concrete;
using System;

namespace DrillAdapter
{
    class Program
    {
        static void Main()
        {
            var europeanPlug = new EuropeanPlug();
            var american = new AmericanToEuropeanPlugAdapter(europeanPlug);

            var drill = new AmericanDrill(american);

            drill.TurnOn();

            Console.ReadKey();
        }
    }
}