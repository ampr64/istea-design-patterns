using System;
using System.Threading.Tasks;

namespace PizzaDelivery.Command
{
    public class DeliveryHandler
    {
        private IDeliveryCommand _command;

        public DeliveryHandler(IDeliveryCommand command) => _command = command;

        public void SetDelivery(IDeliveryCommand command) => _command = command;

        public async Task MakeDelivery()
        {
            Console.WriteLine($"{_command?.GetType().Name} is being dispatched.");
            await _command.ExecuteAsync();
            Console.WriteLine("We just made another customer happy!");
        }
    }
}