using PizzaDelivery.Command;
using PizzaDelivery.Command.Commands;
using PizzaDelivery.Composite;
using PizzaDelivery.Composite.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    class Program
    {
        static async Task Main()
        {
            var products = new List<Product>
            {
                new Pasty(),
                new Pizza(),
                new Pizza(),
                new Pizza(),
                new Soda(),
                new Pasty(),
                new Pasty(),
                new Pasty(),
                new Soda(),
                new Soda(),
                new Soda(),
                new Pizza(),
                new Pizza(),
                new Pizza(),
            };

            var order1 = new Order()
                .WithItem(new Pasty())
                .WithItem(new Pizza())
                .WithItem(new Soda());

            var order2 = new Order()
                .WithItem(new Pizza())
                .WithItem(new Pizza())
                .WithItem(new Soda());

            var order3 = new Order()
                .WithItem(order2)
                .WithItem(new Pasty());

            var takeAwayCommand = new TakeAwayCommand(order1, "Julio Iglesias");
            var courierCommand = new CourierDeliveryCommand(order3, 350, "Avenida Maipú 1800");

            var deliveryHandler = new NewOrderHandler(takeAwayCommand);
            await deliveryHandler.Handle();

            deliveryHandler.SetNewOrderCommand(courierCommand);
            await deliveryHandler.Handle();
        }
    }
}