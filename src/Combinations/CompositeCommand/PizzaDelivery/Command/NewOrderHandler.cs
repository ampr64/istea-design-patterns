using System;
using System.Threading.Tasks;

namespace PizzaDelivery.Command
{
    public class NewOrderHandler
    {
        private INewOrderCommand _command;

        public NewOrderHandler(INewOrderCommand command) => _command = command;

        public void SetNewOrderCommand(INewOrderCommand command) => _command = command;

        public async Task Handle()
        {
            Console.WriteLine($"{_command?.GetType().Name} is being executed.");
            await _command.Execute();
            Console.WriteLine("We just made another customer happy!");
        }
    }
}