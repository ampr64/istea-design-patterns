using InstrumentFactory.Abstract;

namespace InstrumentFactory.Concrete.String
{
    public class Bass : StringInstrument
    {
        private Bass(string model, int stringCount) : base(model, stringCount)
        {
        }
    }
}