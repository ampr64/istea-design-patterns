namespace RestaurantManagement.Strategy
{
    public class EPayment : PaymentMethod
    {
        public override decimal Charge => 0.07m;

        public override string DisplayName => "Electronic payment";
    }
}