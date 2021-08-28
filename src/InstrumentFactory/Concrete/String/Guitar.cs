using InstrumentFactory.Abstract;

namespace InstrumentFactory.Concrete.String
{
    public class Guitar : StringInstrument
    {
        private Guitar(string model, int stringCount) : base(model, stringCount)
        {
        }
    }
}