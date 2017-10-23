using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Sauces;

namespace PizzaFactory.Core.Common
{
    public class SimpleFactory : ISimpleFactory
    {
        public Dough CreateDough(DoughType type)
        {
            throw new System.NotImplementedException();
        }

        public Sauce CreateSauce(SauceType type)
        {
            throw new System.NotImplementedException();
        }
    }
}
