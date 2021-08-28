using InstrumentFactory.Abstract;

namespace InstrumentFactory.Factory
{
    public abstract class InstrumentFactoryBase<TFactory, TInstrument> : IInstrumentFactory<TInstrument>
        where TFactory : IInstrumentFactory<TInstrument>
        where TInstrument : IInstrument
    {
        private static readonly Dictionary<Type, Func<string, TInstrument>> _creators = new();

        public T Create<T>(string model) where T : TInstrument
        {
            var creator = _creators.GetValueOrDefault(typeof(T));
            if (creator is null)
                throw new Exception($"{typeof(T).Name} has not been registered.");

            return (T)creator.Invoke(model);
        }

        protected void RegisterCreator<T>(Func<string, TInstrument> creator) where T : TInstrument => _creators.Add(typeof(T), creator);
    }
}