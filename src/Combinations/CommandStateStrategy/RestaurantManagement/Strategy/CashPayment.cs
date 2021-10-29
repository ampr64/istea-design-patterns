namespace RestaurantManagement.Strategy
{
    public class CashPayment : PaymentMethod
    {
        public override decimal Charge => 0;
    }
}