using RestaurantManagement.State;
using RestaurantManagement.Strategy;

namespace RestaurantManagement.Command
{
    public class PayTableCommand : ICommand
    {
        private readonly Table _table;
        private readonly IPaymentMethod _paymentMethod;

        public PayTableCommand(Table table, IPaymentMethod paymentMethod)
        {
            _table = table;
            _paymentMethod = paymentMethod;
        }

        public void Execute() => _table.Pay(_paymentMethod);
    }
}