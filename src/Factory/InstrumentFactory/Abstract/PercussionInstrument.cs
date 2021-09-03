using System;

namespace InstrumentFactory.Abstract
{
    public class PercussionInstrument : IInstrument
    {
        public string Model { get; }

        public int DrumCount { get; }

        protected PercussionInstrument(string model, int drumCount)
        {
            Model = model;
            DrumCount = drumCount;
        }

        public void PrintDrums() => Console.WriteLine($"This {GetType().Name.ToLower()} has {DrumCount} drums.");
    }
}