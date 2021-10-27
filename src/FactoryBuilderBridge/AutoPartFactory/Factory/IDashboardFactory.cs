using AutoPartFactory.Model;

namespace AutoPartFactory.Factory
{
    public interface IDashboardFactory
    {
        TDashboard Create<TDashboard>(bool hasAirConditioning) where TDashboard : IDashboard;
    }
}