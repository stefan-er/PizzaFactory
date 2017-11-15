using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Sauces;

namespace PizzaFactory.Core.Common
{
    public interface ISimpleFactory
    {
        Pizza CreatePizza(PizzaSize size, DoughType dough, SauceType sauce);
        T CreateTopping<T>(object type) where T : Topping;
    }
}
