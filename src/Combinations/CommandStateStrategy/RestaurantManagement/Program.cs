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

            table1.Pay(new CashPayment());
            table2.Pay(new CreditCardPayment());
            table3.Pay(new EPayment());

            table2.Reopen();

            table3.Pay(new CashPayment());
            table3.Order(10);

            table2.Order(5);
        }
    }
}