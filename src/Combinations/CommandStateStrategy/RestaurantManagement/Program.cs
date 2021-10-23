using RestaurantManagement.Command;
using RestaurantManagement.State;
using RestaurantManagement.Strategy;

namespace RestaurantManagement
{
    class Program
    {
        static void Main()
        {
            var table1 = new Table(1);
            table1.Order(10);

            var table2 = new Table(2);
            table2.Order(50);

            var table3 = new Table(3);
            table3.Order(100);

            var payTable1Command = new PayTableCommand(table1, new CashPayment());
            var payTable2Command = new PayTableCommand(table1, new CreditCardPayment());
            var payTable3Command = new PayTableCommand(table1, new EPayment());

            payTable1Command.Execute();
            payTable2Command.Execute();
            payTable3Command.Execute();

            table2.Reopen();

            payTable3Command.Execute();
            table3.Order(10);

            table2.Order(5);
        }
    }
}