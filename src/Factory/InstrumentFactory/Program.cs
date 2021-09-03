using InstrumentFactory.Abstract;
using InstrumentFactory.Concrete.Percussion;
using InstrumentFactory.Concrete.String;
using InstrumentFactory.Factory;

namespace InstrumentFactory
{
    class Program
    {
        static void Main()
        {
            var stringInstrumentFactory = new StringInstrumentFactory();
            var percussionInstrumentFactory = new PercussionInstrumentFactory();

            var guitar = stringInstrumentFactory.Create<Guitar>("Les Paul");
            var bass = stringInstrumentFactory.Create<Bass>("Fender");
            var drumSet = percussionInstrumentFactory.Create<DrumSet>("Pearl");
            var percussionSet = percussionInstrumentFactory.Create<PercussionSet>("Yamaha");

            ((IInstrument)guitar).Play();
            guitar.PrintStrings();

            ((IInstrument)bass).Play();
            bass.PrintStrings();

            ((IInstrument)drumSet).Play();
            drumSet.PrintDrums();

            ((IInstrument)percussionSet).Play();
            percussionSet.PrintDrums();
        }
    }
}