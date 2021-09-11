namespace PizzaDelivery.Composite
{
    public interface IProduct : IDeliverable
    {
        public decimal Price { get; }
    }
}