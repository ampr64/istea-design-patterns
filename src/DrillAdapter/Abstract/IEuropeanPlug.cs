namespace DrillAdapter.Abstract
{
    public interface IEuropeanPlug : IPlug
    {
        new int Voltage => 220;
    }
}