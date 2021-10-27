namespace AutoPartFactory.Model
{
    public interface IVehicle<TChassis, TDashboard, TFrontEnd>
        where TChassis : IChassis
        where TDashboard : IDashboard
        where TFrontEnd : IFrontEnd
    {
        TChassis Chassis { get; }

        TDashboard Dashboard { get; }

        TFrontEnd FrontEnd { get; }
    }
}