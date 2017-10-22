using PizzaFactory.Core.Meats;
using PizzaFactory.Core.Pizzas;

namespace PizzaFactory.Core.PizzaDecorators
{
    public class MeatDecorator : PizzaDecorator<Meat>
    {
        public MeatDecorator(Pizza pizza, params Meat[] meats) 
            : base(pizza, meats)
        {
        }
    }
}
