using PizzaFactory.Core.Cheeses;
using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Meats;
using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Sauces;
using PizzaFactory.Core.Vegetables;
using System;

namespace PizzaFactory.Core.Common
{
    public class SimpleFactory : ISimpleFactory
    {
        public Pizza CreatePizza(PizzaSize size, DoughType doughType, SauceType sauceType)
        {
            Pizza instance = null;

            Dough dough = CreateDough(doughType);
            Sauce sauce = CreateSauce(sauceType);

            switch (size)
            {
                case PizzaSize.Small:
                    instance = new SmallPizza(dough, sauce);
                    break;
                case PizzaSize.Medium:
                    instance = new MediumPizza(dough, sauce);
                    break;
                case PizzaSize.Large:
                    instance = new LargePizza(dough, sauce);
                    break;
                default:
                    throw new Exception("No such pizza size");
            }

            return instance;
        }
        public T CreateTopping<T>(object type) where T : Topping
        {
            Topping topping = null;

            if (typeof(T) == typeof(Cheese))
            {
                topping = CreateCheese(Enum.Parse<CheeseType>(type.ToString()));
            }
            else if (typeof(T) == typeof(Meat))
            {
                topping = CreateMeat(Enum.Parse<MeatType>(type.ToString()));
            }
            else if (typeof(T) == typeof(Vegetable))
            {
                topping = CreateVegetable(Enum.Parse<VegetableType>(type.ToString()));
            }

            return (T)topping;
        }

        private Dough CreateDough(DoughType type)
        {
            Dough instance = null;

            switch (type)
            {
                case DoughType.White:
                    instance = new WhiteDough();
                    break;
                case DoughType.Wholemeal:
                    instance = new WholemealDough();
                    break;
                default:
                    throw new Exception("No such dough type");
            }

            return instance;
        }
        private Sauce CreateSauce(SauceType type)
        {
            Sauce instance = null;

            switch (type)
            {
                case SauceType.Tomato:
                    instance = new TomatoSauce();
                    break;
                case SauceType.Barbeque:
                    instance = new BarbequeSauce();
                    break;
                default:
                    throw new Exception("No such sauce type");
            }

            return instance;
        }
        private Cheese CreateCheese(CheeseType type)
        {
            Cheese instance = null;

            switch (type)
            {
                case CheeseType.Mozzarella:
                    instance = new Mozzarella();
                    break;
                case CheeseType.Parmesan:
                    instance = new Parmesan();
                    break;
                default:
                    throw new Exception("No such cheese type");
            }

            return instance;
        }
        private Meat CreateMeat(MeatType type)
        {
            Meat instance = null;

            switch (type)
            {
                case MeatType.Pepperoni:
                    instance = new Pepperoni();
                    break;
                case MeatType.Prosciutto:
                    instance = new Prosciutto();
                    break;
                default:
                    throw new Exception("No such meat type");
            }

            return instance;
        }
        private Vegetable CreateVegetable(VegetableType type)
        {
            Vegetable instance = null;

            switch (type)
            {
                case VegetableType.Corn:
                    instance = new Corn();
                    break;
                case VegetableType.Onion:
                    instance = new Onion();
                    break;
                case VegetableType.Pepper:
                    instance = new Pepper();
                    break;
                case VegetableType.Tomato:
                    instance = new Tomato();
                    break;
                default:
                    throw new Exception("No such vegetable type");
            }

            return instance;
        }
    }
}
