using PizzaDelivery.Composite;
using System;
using System.Threading.Tasks;

namespace PizzaDelivery.Command.Commands
{
    public class TakeAwayCommand : INewOrderCommand
    {
        private readonly IOrder _order;
        private readonly string _pickupBy;

        public TakeAwayCommand(IOrder order, string pickupBy)
        {
            if (string.IsNullOrWhiteSpace(pickupBy)) throw new ArgumentException($"'{nameof(pickupBy)}' cannot be null or whitespace.", nameof(pickupBy));
            _order = order;
            _pickupBy = pickupBy;
        }

        public async Task Execute()
        {
            _order.DispatchTakeAway(_pickupBy);

            await PrepareOrder();
            await HandOver();
        }

        private static Task PrepareOrder() => Task.Run(() =>
       {
           Console.WriteLine("Order is being prepared...");
           Task.Delay(7500).Wait();
           Console.WriteLine("Finished preparing order.");
       });

        private Task HandOver() => Task.Run(() =>
        {
            Console.WriteLine($"Attendant is taking the order to the counter.");
            Task.Delay(2500).Wait();
            Console.WriteLine($"Attendant has handed over the order to {_pickupBy}.");
        });
    }
}