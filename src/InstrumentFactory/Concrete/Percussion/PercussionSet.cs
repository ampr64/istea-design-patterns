using InstrumentFactory.Abstract;

namespace InstrumentFactory.Concrete.Percussion
{
    public class PercussionSet : PercussionInstrument
    {
        private PercussionSet(string model, int drumCount) : base(model, drumCount)
        {
        }
    }
}