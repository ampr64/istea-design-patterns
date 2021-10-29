using RestaurantManagement.Strategy;
using System;
using System.Collections.Generic;

namespace RestaurantManagement.Command
{
    public class PayTableCommand : ICommand
    {
        private readonly int _tableNumber;
        private readonly decimal _amount;
        private readonly IPaymentMethod _paymentMethod;

        private decimal PaymentFee => FeeByPaymentMethod[_paymentMethod.GetType()];

        private decimal GrandTotal => _amount * (1 + PaymentFee);

        private static IReadOnlyDictionary<Type, decimal> FeeByPaymentMethod =>
            new Dictionary<Type, decimal>
        {
            { typeof(CashPayment), 0m },
            { typeof(CreditCardPayment), 0.1m },
            { typeof(EPayment), 0.07m }
        };

        public PayTableCommand(int tableNumber, decimal amount, IPaymentMethod paymentMethod)
        {
            _tableNumber = tableNumber;
            _amount = amount;
            _paymentMethod = paymentMethod ?? throw new ArgumentNullException(nameof(paymentMethod));
        }

        public void Execute() => Console.WriteLine($"Table {_tableNumber} just paid their bill with {_paymentMethod.GetType().Name} (+{PaymentFee * 100:G29}%), for a grand amount of ${GrandTotal:G29}!");
    }
}