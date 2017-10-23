using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Sauces;
using System;
using PizzaFactory.Core.Cheeses;
using PizzaFactory.Core.Meats;
using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Vegetables;

namespace PizzaFactory.Core.Common
{
    public class SimpleFactory : ISimpleFactory
    {
        public Pizza CreatePizza(PizzaSize size, Dough dough, Sauce sauce)
        {
            Pizza instance = null;

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

        public Dough CreateDough(DoughType type)
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

        public Sauce CreateSauce(SauceType type)
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

        public Cheese CreateCheese(CheeseType type)
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

        public Meat CreateMeat(MeatType type)
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

        public Vegetable CreateVegetable(VegetableType type)
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
