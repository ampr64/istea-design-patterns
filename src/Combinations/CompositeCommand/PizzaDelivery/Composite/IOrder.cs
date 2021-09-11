using System.Collections.Generic;
using System.Linq;

namespace PizzaDelivery.Composite
{
    public interface IOrder : IDeliverable
    {
        IReadOnlyList<IDeliverable> Items { get; }

        decimal Total => Items.OfType<IProduct>().Sum(p => p.Price);
    }
}