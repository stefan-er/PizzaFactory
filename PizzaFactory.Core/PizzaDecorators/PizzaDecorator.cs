using PizzaFactory.Core.Pizzas;

namespace PizzaFactory.Core.PizzaDecorators
{
    public class PizzaDecorator : Pizza
    {
        private Pizza pizza;

        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
    }
}
