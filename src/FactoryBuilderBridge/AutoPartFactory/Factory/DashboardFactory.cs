using AutoPartFactory.Model;
using System;

namespace AutoPartFactory.Factory
{
    public class DashboardFactory : IDashboardFactory
    {
        public TDashboard Create<TDashboard>(bool hasAirConditioning) where TDashboard : IDashboard =>
            (TDashboard)Activator.CreateInstance(typeof(TDashboard), args: hasAirConditioning);
    }
}