using PizzaDelivery.Composite;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDelivery.Command.Commands
{
    public class CourierDeliveryCommand : INewOrderCommand
    {
        private readonly IOrder _order;
        private readonly decimal _deliveryFees;
        private readonly string _address;

        public CourierDeliveryCommand(IOrder order, decimal deliveryFees, string address)
        {
            if (string.IsNullOrWhiteSpace(address)) throw new ArgumentException($"'{nameof(address)}' cannot be null or whitespace.", nameof(address));
            _order = order ?? throw new ArgumentNullException(nameof(order));
            _deliveryFees = deliveryFees;
            _address = address;
        }

        public async Task Execute()
        {
            _order.DispatchDelivery(_deliveryFees, _address);

            await DeliverToAddress();
            await HandOverAndCharge();
        }

        private Task DeliverToAddress() => Task.Run(() =>
        {
            Console.WriteLine($"Courier is heading to {_address}...");
            Task.Delay(10000).Wait();
            Console.WriteLine($"Courier has arrived at {_address}.");
        });

        private Task HandOverAndCharge() => Task.Run(() =>
        {
            Task.Delay(3000).Wait();
            Console.WriteLine($"Courier has handed over the delivery and charged ${_deliveryFees}.");
        });
    }
}