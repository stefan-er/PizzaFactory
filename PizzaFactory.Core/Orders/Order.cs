using PizzaFactory.Infrastructure;

namespace PizzaFactory.Core.Orders
{
    public class Order : ValueObject<Order>
    {
        protected override bool EqualsCore(Order other)
        {
            throw new System.NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new System.NotImplementedException();
        }
    }
}
