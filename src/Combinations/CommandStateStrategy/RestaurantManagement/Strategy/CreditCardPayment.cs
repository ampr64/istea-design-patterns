namespace RestaurantManagement.Strategy
{
    public class CreditCardPayment : PaymentMethod
    {
        public override decimal Charge => 0.10m;
    }
}