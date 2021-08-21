using DrillAdapter.Abstract;

namespace DrillAdapter.Adapter
{
    public class AmericanToEuropeanPlugAdapter : IAmericanPlug
    {
        private readonly IEuropeanPlug _europeanPlug;

        public AmericanToEuropeanPlugAdapter(IEuropeanPlug europeanPlug) => _europeanPlug = europeanPlug;

        public int Voltage => _europeanPlug.Voltage / 2;
    }
}