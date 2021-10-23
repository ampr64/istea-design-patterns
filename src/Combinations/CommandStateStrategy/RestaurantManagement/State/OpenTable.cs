using RestaurantManagement.Strategy;
using System;
using System.Collections.Generic;

namespace RestaurantManagement.State
{
    public class OpenTable : TableState
    {
        public OpenTable(Table context) : base(context)
        {
        }

        private static IReadOnlyDictionary<Type, (decimal PaymentFee, double FeePercentage)> PaymentLookup => new Dictionary<Type, (decimal PaymentFee, double FeePercentage)>
        {
            { typeof(CashPayment), (1m, 0) },
            { typeof(CreditCardPayment), (1.1m, 10) },
            { typeof(EPayment), (1.07m, 7) }
        };

        public override void Order(decimal amount)
        {
            Console.WriteLine($"Table {Context.Number} just added {amount} to their bill!");
            BillAmount += amount;
        }

        public override void Pay(IPaymentMethod paymentMethod)
        {
            var paymentInfo = PaymentLookup[paymentMethod.GetType()];
            BillAmount *= paymentInfo.PaymentFee;
            Console.WriteLine($"Table {Context.Number} just paid their bill with {paymentMethod.GetType().Name} (+{paymentInfo.FeePercentage}%), for a grand amount of (${BillAmount})!");
            Context.TransitionTo(new ClosedTable(Context, this));
        }

        public override void Reopen() => Console.WriteLine("Table is already open!");
    }
}