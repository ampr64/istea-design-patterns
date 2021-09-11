using System;
using System.Threading.Tasks;

namespace PizzaDelivery.Command.Commands
{
    public class TakeAwayDeliveryCommand : IDeliveryCommand
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public TakeAwayDeliveryCommand(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException($"'{nameof(firstName)}' cannot be null or whitespace.", nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException($"'{nameof(lastName)}' cannot be null or whitespace.", nameof(lastName));

            _firstName = firstName;
            _lastName = lastName;
        }

        public async Task ExecuteAsync()
        {
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
            Console.WriteLine($"Attendant is picking up the order.");
            Task.Delay(2500).Wait();
            Console.WriteLine($"Attendant has handed over the order to {_firstName} {_lastName}.");
        });
    }
}