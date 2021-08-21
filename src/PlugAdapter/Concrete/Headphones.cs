using PlugAdapter.Interfaces;
using System;

namespace PlugAdapter.Concrete
{
    public class Headphones
    {
        private readonly IMiniPlug _miniPlug;

        public Headphones(IMiniPlug miniPlug) => _miniPlug = miniPlug ?? throw new ArgumentNullException(nameof(miniPlug));

        public void PrintPlugInfo() => Console.WriteLine("Plugged into headphones plug of type {0} with output of {1} MHz.", _miniPlug.GetType().Name, _miniPlug.Frequency);
    }
}