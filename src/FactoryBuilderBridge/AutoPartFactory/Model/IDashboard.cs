namespace AutoPartFactory.Model
{
    public interface IDashboard : IVehiclePart
    {
        bool HasAirConditioning { get; }
    }
}