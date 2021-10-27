using AutoPartFactory.Model;

namespace AutoPartFactory.Factory
{
    public interface IAutoPartFactory<TPart> where TPart : IAutoPart
    {
        public TPart Create();
    }

    public interface IAutoPartFactory<TPart, TParameter> where TPart : IAutoPart
    {
        public TPart Create(TParameter parameter);
    }
}