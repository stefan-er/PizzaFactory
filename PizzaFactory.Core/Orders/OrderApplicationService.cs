using PizzaFactory.Core.Cheeses;
using PizzaFactory.Core.Common;
using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Meats;
using PizzaFactory.Core.Orders.Commands;
using PizzaFactory.Core.PizzaDecorators;
using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Sauces;
using PizzaFactory.Core.Vegetables;
using PizzaFactory.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace PizzaFactory.Core.Orders
{
    public class OrderApplicationService : ApplicationService,
        ICommandHandler<PlaceOrder>
    {
        public OrderApplicationService(IRepository repository, ISimpleFactory factory)
            : base(repository)
        {
            Factory = factory;
        }

        public ISimpleFactory Factory { get; set; }

        public void Handle(PlaceOrder command)
        {
            Dough dough = Factory.CreateDough(command.DoughType);
            Sauce sauce = Factory.CreateSauce(command.SauceType);

            Pizza pizza = Factory.CreatePizza(command.Size, dough, sauce);

            Pizza decoratedPizza = pizza;

            if (command.Cheeses != null)
            {
                var cheeses = new HashSet<Cheese>();
                foreach (CheeseType type in command.Cheeses)
                {
                    Cheese cheese = Factory.CreateCheese(type);
                    cheeses.Add(cheese);
                }

                decoratedPizza = new CheeseDecorator(decoratedPizza, cheeses.ToArray());
            }

            if (command.Meats != null)
            {
                var meats = new HashSet<Meat>();
                foreach (MeatType type in command.Meats)
                {
                    Meat meat = Factory.CreateMeat(type);
                    meats.Add(meat);
                }

                decoratedPizza = new MeatDecorator(decoratedPizza, meats.ToArray());
            }

            if (command.Vegetables != null)
            {
                var vegetables = new HashSet<Vegetable>();
                foreach (VegetableType type in command.Vegetables)
                {
                    Vegetable vegetable = Factory.CreateVegetable(type);
                    vegetables.Add(vegetable);
                }

                decoratedPizza = new VegetablesDecorator(decoratedPizza, vegetables.ToArray());
            }

            var order = new Order(command.Id, decoratedPizza.GetIngredients(), command.Date, command.CalledBy);

            Repository.Save(order, command.CalledBy);
        }
    }
}
