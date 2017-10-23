using PizzaFactory.Core.Orders.Commands;
using PizzaFactory.Infrastructure;

namespace PizzaFactory.Core.Orders
{
    public class OrderApplicationService : ApplicationService,
        ICommandHandler<PlaceOrder>
    {
        public void Handle(PlaceOrder command)
        {
            var id = command.Id;
        }
    }
}
