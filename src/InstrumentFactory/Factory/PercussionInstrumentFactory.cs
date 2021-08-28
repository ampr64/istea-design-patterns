using InstrumentFactory.Abstract;
using InstrumentFactory.Concrete.Percussion;
using System.Reflection;

namespace InstrumentFactory.Factory
{
    public class PercussionInstrumentFactory : InstrumentFactoryBase<PercussionInstrumentFactory, PercussionInstrument>
    {
        public PercussionInstrumentFactory()
        {
            RegisterCreator<DrumSet>(model => (DrumSet)Activator.CreateInstance(typeof(DrumSet), BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { model, 7 }, null)!);
            RegisterCreator<PercussionSet>(model => (PercussionSet)Activator.CreateInstance(typeof(PercussionSet), BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { model, 3 }, null)!);
        }
    }
}