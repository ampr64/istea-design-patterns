using RestaurantManagement.Strategy;
using System;

namespace RestaurantManagement.State
{
    public class Table
    {
        private TableState _state;

        public int Number { get; }

        public Table(int number)
        {
            Number = number;
            _state = new OpenTable(this);
        }

        public void TransitionTo(TableState state)
        {
            if (state.GetType() == typeof(ClosedTable) && _state.GetType() == typeof(OpenTable) && _state.BillAmount == 0)
            {
                Console.WriteLine("Cannot close an unbilled table!");
                return;
            }

            Console.WriteLine($"{nameof(Table)} transitioning to {state.GetType().Name}");
            _state = state;
        }

        public void Order(decimal amount) => _state.Order(amount);

        public void Pay(IPaymentMethod paymentMethod) => _state.Pay(paymentMethod);

        public void Reopen() => _state.Reopen();
    }
}