using PizzaFactory.Infrastructure;

namespace PizzaFactory.Core.Orders
{
    public class Order : EntityBase<int>
    {
        public Order(int id)
            : base(id)
        {
        }
    }
}
