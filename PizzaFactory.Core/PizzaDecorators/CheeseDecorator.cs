using PizzaFactory.Core.Cheeses;
using PizzaFactory.Core.Pizzas;

namespace PizzaFactory.Core.PizzaDecorators
{
    public class CheeseDecorator : PizzaDecorator<Cheese>
    {
        public CheeseDecorator(Pizza pizza, params Cheese[] cheeses)
            : base(pizza, cheeses)
        {
            ToppingType = ToppingType.Cheese;
        }
    }
}
