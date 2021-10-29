using RestaurantManagement.Command;
using RestaurantManagement.Strategy;
using System;

namespace RestaurantManagement.State
{
    public class Table
    {
        private TableState _state;

        public int Number { get; }

        public decimal BillAmount => _state.BillAmount;

        public Table(int number)
        {
            Number = number;
            _state = new OpenTable(this);
        }

        public void TransitionTo(TableState state)
        {
            if (state.GetType() == typeof(ClosedTable) && _state.GetType() == typeof(OpenTable) && BillAmount == 0)
            {
                Console.WriteLine("Cannot close an unbilled table!");
                return;
            }

            Console.WriteLine($"{nameof(Table)} {Number} transitioning to {state.GetType().Name}");
            _state = state;
        }

        public void Order(decimal amount) => _state.Order(amount);

        public void Pay(PaymentMethod paymentMethod) => _state.Pay(new PayTableCommand(Number, BillAmount, paymentMethod));

        public void Reopen() => _state.Reopen();
    }
}