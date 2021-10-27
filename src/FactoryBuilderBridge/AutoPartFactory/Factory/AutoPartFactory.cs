using AutoPartFactory.Model;
using System;

namespace AutoPartFactory.Factory
{
    public abstract class AutoPartFactory<TPart> : IAutoPartFactory<TPart>
        where TPart : IAutoPart
    {
        protected abstract Func<TPart> Instantiator { get; }

        public T Create<T>() where T : TPart => Instantiator.Invoke();
    }

    public abstract class AutoPartFactory<TPart, TParameter> : IAutoPartFactory<TPart, TParameter>
        where TPart : IAutoPart
    {
        public TPart Create(TParameter parameter)
        {
            throw new NotImplementedException();
        }
    }
}