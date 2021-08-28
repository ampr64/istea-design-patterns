namespace InstrumentFactory.Abstract
{
    public interface IInstrument
    {
        string Model { get; }

        void Play() => Console.WriteLine($"{Model} {GetType().Name.ToLower()} is being played.");
    }
}