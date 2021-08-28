using InstrumentFactory.Abstract;

namespace InstrumentFactory.Factory
{
    public interface IInstrumentFactory<TInstrument> where TInstrument : IInstrument
    {
        T Create<T>(string model) where T : TInstrument;
    }
}