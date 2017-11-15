using PizzaFactory.Core.Cheeses;
using PizzaFactory.Core.Common;
using PizzaFactory.Core.Meats;
using PizzaFactory.Core.Orders.Commands;
using PizzaFactory.Core.PizzaDecorators;
using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Vegetables;
using PizzaFactory.Infrastructure;
using System.Collections;
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
            Pizza pizza = Factory.CreatePizza(command.Size, command.DoughType, command.SauceType);

            if (command.Cheeses != null)
            {
                Cheese[] cheeses = GetToppings<Cheese>(command.Cheeses);
                pizza = new CheeseDecorator(pizza, cheeses);
            }

            if (command.Meats != null)
            {
                Meat[] meats = GetToppings<Meat>(command.Meats);
                pizza = new MeatDecorator(pizza, meats);
            }

            if (command.Vegetables != null)
            {
                Vegetable[] vegetables = GetToppings<Vegetable>(command.Vegetables);
                pizza = new VegetablesDecorator(pizza, vegetables);
            }

            var order = new Order(command.Id, pizza.GetIngredients(), command.Date, command.CalledBy);

            Repository.Save(order, command.CalledBy);
        }

        //TODO: Move this method to Toppings class
        private T[] GetToppings<T>(IEnumerable types) where T : Topping
        {
            var toppings = new HashSet<T>();
            foreach (var type in types)
            {
                T topping = Factory.CreateTopping<T>(type);
                toppings.Add(topping);
            }

            return toppings.ToArray();
        }
    }
}
