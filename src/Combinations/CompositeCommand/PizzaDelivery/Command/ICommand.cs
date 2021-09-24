using System.Threading.Tasks;

namespace PizzaDelivery.Command
{
    public interface ICommand
    {
        Task Execute();
    }
}