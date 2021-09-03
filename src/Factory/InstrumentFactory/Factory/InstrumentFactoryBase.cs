using InstrumentFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace InstrumentFactory.Factory
{
    public abstract class InstrumentFactoryBase<TFactory, TInstrument> : IInstrumentFactory<TInstrument>
        where TFactory : IInstrumentFactory<TInstrument>
        where TInstrument : IInstrument
    {
        private static readonly Dictionary<Type, int> _instrumentTypeByCountMap = new();

        public T Create<T>(string model) where T : TInstrument
        {
            var count = _instrumentTypeByCountMap.GetValueOrDefault(typeof(T));
            if (count is 0)
                throw new Exception($"{typeof(T).Name} has not been registered.");

            return (T)Activator.CreateInstance(typeof(T), BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { model, count }, null)!;
        }

        protected void Register<T>(int count) where T : TInstrument => _instrumentTypeByCountMap.Add(typeof(T), count);
    }
}