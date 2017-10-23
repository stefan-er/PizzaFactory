using PizzaFactory.Core.Pizzas;
using PizzaFactory.Infrastructure;
using System;

namespace PizzaFactory.Core.Orders
{
    public class Order : EntityBase<Guid>
    {
        public Order(Guid id, Pizza pizza, DateTime date, string customer)
            : base(id)
        {
            Pizza = pizza;
            Date = date;
            Customer = customer;
        }

        public Pizza Pizza { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
    }
}
