using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Sauces;

namespace PizzaFactory.Core.Pizzas
{
    public class SmallPizza : Pizza
    {
        public SmallPizza(Dough dough, Sauce sauce) : base(dough, sauce)
        {
        }
    }
}
