using InstrumentFactory.Abstract;
using InstrumentFactory.Concrete.String;
using System.Reflection;

namespace InstrumentFactory.Factory
{
    public class StringInstrumentFactory : InstrumentFactoryBase<StringInstrumentFactory, StringInstrument>
    {
        public StringInstrumentFactory()
        {
            RegisterCreator<Guitar>(model => (Guitar)Activator.CreateInstance(typeof(Guitar), BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { model, 6 }, null)!);
            RegisterCreator<Bass>(model => (Bass)Activator.CreateInstance(typeof(Bass), BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { model, 4 }, null)!);
        }
    }
}