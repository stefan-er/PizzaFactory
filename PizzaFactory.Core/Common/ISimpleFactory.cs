using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Sauces;

namespace PizzaFactory.Core.Common
{
    public interface ISimpleFactory
    {
        Dough CreateDough(DoughType type);
        Sauce CreateSauce(SauceType type);
    }
}
