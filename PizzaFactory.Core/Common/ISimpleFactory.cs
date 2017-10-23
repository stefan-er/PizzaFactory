using PizzaFactory.Core.Cheeses;
using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Meats;
using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Sauces;
using PizzaFactory.Core.Vegetables;

namespace PizzaFactory.Core.Common
{
    public interface ISimpleFactory
    {
        Pizza CreatePizza(PizzaSize size, Dough dough, Sauce sauce);
        Dough CreateDough(DoughType type);
        Sauce CreateSauce(SauceType type);
        Cheese CreateCheese(CheeseType type);
        Meat CreateMeat(MeatType type);
        Vegetable CreateVegetable(VegetableType type);
    }
}
