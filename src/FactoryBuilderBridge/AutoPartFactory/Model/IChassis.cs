namespace AutoPartFactory.Model
{
    public interface IChassis : IAutoPart
    {
        int WheelCount { get; }
    }
}