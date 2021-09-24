using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaDelivery.Composite
{
    public class Order : IOrder
    {
        private string _pickupBy;
        private decimal _deliveryFee;
        private string _deliveryAddress;

        private readonly List<IDeliverable> _items = new();
        public IReadOnlyList<IDeliverable> Items => _items.AsReadOnly();

        public decimal Total => Items.OfType<IProduct>().Sum(p => p.Price) + Items.OfType<IOrder>().Sum(o => o.Total) + _deliveryFee;

        public bool IsDispatched { get; private set; }

        public IOrder Dispatch()
        {
            if (IsDispatched) throw new InvalidOperationException("This order has already been dispatched");

            IsDispatched = true;
            Console.WriteLine($"Dispatched order\n{this}");

            return this;
        }

        public void DispatchTakeAway(string pickupBy)
        {
            if (IsDispatched) throw new InvalidOperationException("This order has already been dispatched");
            if (string.IsNullOrWhiteSpace(pickupBy)) throw new ArgumentException($"'{nameof(pickupBy)}' cannot be null or whitespace.", nameof(pickupBy));

            Items.OfType<IOrder>().ToList().ForEach(o => o.DispatchTakeAway(pickupBy));

            _pickupBy = pickupBy;
            IsDispatched = true;

            Console.WriteLine($"Dispatched order\n{this} for take away.");
        }

        public void DispatchDelivery(decimal fee, string address)
        {
            if (IsDispatched) throw new InvalidOperationException("This order has already been dispatched");
            if (string.IsNullOrWhiteSpace(address)) throw new ArgumentException($"'{nameof(address)}' cannot be null or whitespace.", nameof(address));

            Items.OfType<IOrder>().ToList().ForEach(o => o.DispatchDelivery(0, address));

            _deliveryFee = fee;
            _deliveryAddress = address;
            IsDispatched = true;

            Console.WriteLine($"Dispatched order\n{this} for delivery.");
        }

        public IOrder WithItem(IDeliverable item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            if (item is IOrder order && order.IsDispatched) throw new ArgumentException("Cannot add orders that have already been dispatched.");
            _items.Add(item);

            return this;
        }

        public override string ToString() => this switch
        {
            { _pickupBy: { Length: > 0 } } => FormatTakeAway(),
            { _deliveryAddress: { Length: > 0 }} => FormatDelivery(),
            _ => FormatDefault()
        };

        private string FormatTakeAway() => new StringBuilder("==========\n")
            .AppendLine($"Picked up by: {_pickupBy}")
            .AppendLine($"{nameof(Items)}:\n{FormatItems()}")
            .AppendLine($"{nameof(Total)}: ${Total}")
            .AppendLine("==========")
            .ToString();

        private string FormatDelivery() => new StringBuilder("==========\n")
            .AppendLine($"Delivery address: {_deliveryAddress}")
            .AppendLine($"{nameof(Items)}:\n{FormatItems()}")
            .AppendLine($"Delivery fees: ${_deliveryFee}")
            .AppendLine($"{nameof(Total)}: ${Total} (incl. delivery fees)")
            .AppendLine("==========")
            .ToString();

        private string FormatItems() =>
            Items.Aggregate(new StringBuilder("------\n"), (builder, item) => builder.AppendLine($"{item}"), result => result.AppendLine("------").ToString());

        private string FormatDefault() => new StringBuilder("==========\n")
            .AppendLine("Incomplete order")
            .AppendLine($"{nameof(Total)}: ${Total}")
            .AppendLine("==========")
            .ToString();
    }
}