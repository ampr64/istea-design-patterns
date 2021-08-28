using InstrumentFactory.Abstract;

namespace InstrumentFactory.Concrete.Percussion
{
    public class DrumSet : PercussionInstrument
    {
        protected DrumSet(string model, int drumCount) : base(model, drumCount)
        {
        }
    }
}