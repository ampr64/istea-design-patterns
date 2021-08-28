namespace InstrumentFactory.Abstract
{
    public abstract class StringInstrument : IInstrument
    {
        public string Model { get; }

        public int StringCount { get; }

        protected StringInstrument(string model, int stringCount)
        {
            Model = model;
            StringCount = stringCount;
        }

        public void PrintStrings() => Console.WriteLine($"This {GetType().Name.ToLower()} has {StringCount} strings.");
    }
}