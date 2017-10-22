using PizzaFactory.Core.Pizzas;
using System.Collections.Generic;

namespace PizzaFactory.Core.PizzaDecorators
{
    public class CheeseDecorator : PizzaDecorator
    {
        private IEnumerable<Cheese.Cheese> cheeseCollection;

        public CheeseDecorator(Pizza pizza, params Cheese.Cheese[] cheese)
            : base(pizza)
        {
            this.cheeseCollection = cheese;
        }
    }
}
