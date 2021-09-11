using System.Collections.Generic;

namespace PizzaDelivery.Composite
{
    public class Order : IOrder
    {
        private readonly List<IDeliverable> _deliverables;
        public IReadOnlyList<IDeliverable> Deliverables => _deliverables.AsReadOnly();


    }
}