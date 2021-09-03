using InstrumentFactory.Abstract;
using InstrumentFactory.Concrete.String;

namespace InstrumentFactory.Factory
{
    public class StringInstrumentFactory : InstrumentFactoryBase<StringInstrumentFactory, StringInstrument>
    {
        public StringInstrumentFactory()
        {
            Register<Guitar>(6);
            Register<Bass>(4);
        }
    }
}