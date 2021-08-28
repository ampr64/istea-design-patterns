using DrillAdapter.Abstract;

namespace DrillAdapter.Concrete
{
    public class EuropeanPlug : IEuropeanPlug
    {
        public int Voltage => 220;
    }
}