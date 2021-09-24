namespace PizzaDelivery.Composite
{
    public abstract class Product : IProduct
    {
        public abstract decimal Price { get; }

        public override string ToString() => $"{GetType().Name}: {Price}";
    }
}