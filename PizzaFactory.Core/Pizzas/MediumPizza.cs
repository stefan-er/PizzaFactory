using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Sauces;

namespace PizzaFactory.Core.Pizzas
{
    public class MediumPizza : Pizza
    {
        public MediumPizza(Dough dough, Sauce sauce) 
            : base(dough, sauce)
        {
            Type = PizzaType.Medium;
        }
    }
}
