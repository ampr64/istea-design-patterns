using System.Collections.Generic;

namespace PizzaDelivery.Composite
{
    public class Order : IOrder
    {
        private readonly List<IDeliverable> _items = new();
        public IReadOnlyList<IDeliverable> Items => _items.AsReadOnly();
    }
}