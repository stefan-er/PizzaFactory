using PizzaFactory.Infrastructure;
using System;

namespace PizzaFactory.Core.Orders
{
    public class Order : EntityBase<Guid>
    {
        public Order(Guid id, string ingredients, DateTime date, string customer)
            : base(id)
        {
            Ingredients = ingredients;
            Date = date;
            Customer = customer;
        }

        public string Ingredients { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
    }
}
