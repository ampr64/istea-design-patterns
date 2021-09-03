using InstrumentFactory.Abstract;
using InstrumentFactory.Concrete.Percussion;

namespace InstrumentFactory.Factory
{
    public class PercussionInstrumentFactory : InstrumentFactoryBase<PercussionInstrumentFactory, PercussionInstrument>
    {
        public PercussionInstrumentFactory()
        {
            Register<DrumSet>(7);
            Register<PercussionSet>(3);
        }
    }
}