using System.Collections.Generic;
using System.Linq;

namespace PizzaDelivery.Composite
{
    public interface IOrder : IDeliverable
    {
        IReadOnlyList<IDeliverable> Deliverables { get; }

        decimal Total => Deliverables.OfType<IProduct>().Sum(p => p.Price);
    }
}