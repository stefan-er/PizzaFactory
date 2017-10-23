using PizzaFactory.Core.Pizzas;
using PizzaFactory.Infrastructure;
using System;

namespace PizzaFactory.Core.Orders
{
    public class Order : EntityBase<Guid>
    {
        public Order(Guid id)
            : base(id)
        {
        }

        public Pizza Pizza { get; set; }
    }
}
