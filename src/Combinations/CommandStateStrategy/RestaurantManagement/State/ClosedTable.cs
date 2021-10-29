using RestaurantManagement.Command;
using System;

namespace RestaurantManagement.State
{
    public class ClosedTable : TableState
    {
        public ClosedTable(Table context, TableState state) : base(context) =>
            BillAmount = state.BillAmount;

        public override void Order(decimal price) => Console.WriteLine("A closed table cannot make orders!");

        public override void Pay(PayTableCommand command) => Console.WriteLine("It's not possible to pay for a closed table!");

        public override void Reopen()
        {
            BillAmount = 0;
            Context.TransitionTo(new OpenTable(Context));
        }
    }
}