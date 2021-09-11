using System.Threading.Tasks;

namespace PizzaDelivery.Command
{
    public interface IAsyncCommand
    {
        Task ExecuteAsync();
    }
}