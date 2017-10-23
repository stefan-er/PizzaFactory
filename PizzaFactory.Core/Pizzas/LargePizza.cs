using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Sauces;

namespace PizzaFactory.Core.Pizzas
{
    public class LargePizza : Pizza
    {
        public LargePizza(Dough dough, Sauce sauce) 
            : base(dough, sauce)
        {
            Size = PizzaSize.Large;
        }
    }
}
