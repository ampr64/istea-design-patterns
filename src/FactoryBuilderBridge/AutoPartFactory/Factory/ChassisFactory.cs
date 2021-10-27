using AutoPartFactory.Model;
using AutoPartFactory.Model.Cars;
using AutoPartFactory.Model.Trucks;
using System;
using System.Collections.Generic;

namespace AutoPartFactory.Factory
{
    public class ChassisFactory : IChassisFactory
    {
        private readonly Dictionary<Type, int> _wheelCountLookup = new()
        {
            {  typeof(CarChassis), 4 },
            {  typeof(TruckChassis), 8 },
        };

        public TChassis Create<TChassis>() where TChassis : IChassis
        {
            if (!_wheelCountLookup.TryGetValue(typeof(TChassis), out var wheelCount)) throw new Exception($"{typeof(TChassis)} is not registered.");

            return (TChassis)Activator.CreateInstance(typeof(TChassis), wheelCount);
        }

        public IChassis Create()
        {
            throw new NotImplementedException();
        }
    }
}