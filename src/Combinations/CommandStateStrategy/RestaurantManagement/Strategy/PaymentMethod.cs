using System;
using Utils.Extensions;

namespace RestaurantManagement.Strategy
{
    public abstract class PaymentMethod
    {
        public abstract decimal Charge { get; }

        public virtual string DisplayName => GetType().Name[0..^"Payment".Length].ToSentence();

        public void Pay(decimal amount) => Console.WriteLine($"{DisplayName} has a charge of {Charge * 100:G29}%, totalling ${amount * (1 + Charge):G29}");
    }
}