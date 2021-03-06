using RestaurantManagement.Command;

namespace RestaurantManagement.State
{
    public abstract class TableState
    {
        public decimal BillAmount { get; protected set; }

        protected Table Context { get; private set; }

        protected TableState(Table context) => SetContext(context);

        public void SetContext(Table context) => Context = context;

        public abstract void Order(decimal amount);

        public abstract void Pay(PayTableCommand command);

        public abstract void Reopen();
    }
}