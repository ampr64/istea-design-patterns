using RestaurantManagement.Command;
using System;

namespace RestaurantManagement.State
{
    public class OpenTable : TableState
    {
        public OpenTable(Table context) : base(context)
        {
        }

        public override void Order(decimal amount)
        {
            Console.WriteLine($"Table {Context.Number} just added {amount} to their bill!");
            BillAmount += amount;
        }

        public override void Pay(PayTableCommand command)
        {
            command.Execute();
            Context.TransitionTo(new ClosedTable(Context, this));
        }

        public override void Reopen() => Console.WriteLine("Table is already open!");
    }
}