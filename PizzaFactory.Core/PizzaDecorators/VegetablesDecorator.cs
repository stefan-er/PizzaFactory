using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Vegetables;

namespace PizzaFactory.Core.PizzaDecorators
{
    public class VegetablesDecorator : PizzaDecorator<Vegetable>
    {
        public VegetablesDecorator(Pizza pizza, params Vegetable[] vegetables) 
            : base(pizza, vegetables)
        {
            ToppingType = ToppingType.Vegetable;
        }
    }
}
