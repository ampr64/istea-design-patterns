using System;
using System.Threading.Tasks;

namespace PizzaDelivery.Command.Commands
{
    public class CourierDeliveryCommand : IDeliveryCommand
    {
        private readonly decimal _deliveryFees;
        private readonly string _address;

        public CourierDeliveryCommand(decimal deliveryFees, string address)
        {
            if (string.IsNullOrWhiteSpace(address)) throw new ArgumentException($"'{nameof(address)}' cannot be null or whitespace.", nameof(address));
            _deliveryFees = deliveryFees;
            _address = address;
        }

        public async Task ExecuteAsync()
        {
            Console.WriteLine($"Courier is heading to {_address}...");
            await DeliverToAddress();
            await HandOverAndCharge();
        }

        private Task DeliverToAddress() => Task.Run(() =>
        {
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