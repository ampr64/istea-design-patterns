namespace AutoPartFactory.Model
{
    public interface IFrontEnd : IVehiclePart
    {
        SteeringType SteeringType { get; }
    }
}