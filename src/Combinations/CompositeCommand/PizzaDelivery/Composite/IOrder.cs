using System.Collections.Generic;

namespace PizzaDelivery.Composite
{
    public interface IOrder : IDeliverable
    {
        IReadOnlyList<IDeliverable> Items { get; }

        IOrder WithItem(IDeliverable item);

        bool IsDispatched { get; }

        void DispatchTakeAway(string pickupBy);

        void DispatchDelivery(decimal fee, string address);

        decimal Total { get; }
    }
}