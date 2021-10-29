using RestaurantManagement.Strategy;
using System;

namespace RestaurantManagement.Command
{
    public class PayTableCommand : ICommand
    {
        private readonly int _tableNumber;
        private readonly decimal _amount;
        private readonly PaymentMethod _paymentMethod;

        public PayTableCommand(int tableNumber, decimal amount, PaymentMethod paymentMethod)
        {
            _tableNumber = tableNumber;
            _amount = amount;
            _paymentMethod = paymentMethod ?? throw new ArgumentNullException(nameof(paymentMethod));
        }

        public void Execute()
        {
            Console.WriteLine($"Table {_tableNumber} chose to pay their bill of ${_amount:G29} with {_paymentMethod.DisplayName}.");
            _paymentMethod.Pay(_amount);
        }
    }
}