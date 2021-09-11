using PizzaDelivery.Command;
using PizzaDelivery.Command.Commands;
using System;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    class Program
    {
        static async Task Main()
        {
            var takeAwayCommand = new TakeAwayDeliveryCommand("Julio", "Iglesias");
            var courierCommand = new CourierDeliveryCommand(350, "Avenida Maipú 1800");

            var deliveryHandler = new DeliveryHandler(takeAwayCommand);
            await deliveryHandler.MakeDelivery();

            deliveryHandler.SetDelivery(courierCommand);
            await deliveryHandler.MakeDelivery();
        }
    }
}
