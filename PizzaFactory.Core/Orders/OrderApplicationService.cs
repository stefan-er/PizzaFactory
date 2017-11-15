using PizzaFactory.Core.Cheeses;
using PizzaFactory.Core.Common;
using PizzaFactory.Core.Meats;
using PizzaFactory.Core.Orders.Commands;
using PizzaFactory.Core.PizzaDecorators;
using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Vegetables;
using PizzaFactory.Infrastructure;

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
                Cheese[] cheeses = Topping.GetToppings<Cheese>(command.Cheeses, Factory);
                pizza = new CheeseDecorator(pizza, cheeses);
            }

            if (command.Meats != null)
            {
                Meat[] meats = Topping.GetToppings<Meat>(command.Meats, Factory);
                pizza = new MeatDecorator(pizza, meats);
            }

            if (command.Vegetables != null)
            {
                Vegetable[] vegetables = Topping.GetToppings<Vegetable>(command.Vegetables, Factory);
                pizza = new VegetablesDecorator(pizza, vegetables);
            }

            var order = new Order(command.Id, pizza.GetIngredients(), command.Date, command.CalledBy);

            Repository.Save(order, command.CalledBy);
        }
    }
}
