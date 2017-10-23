using PizzaFactory.Core.Common;
using System;

namespace PizzaFactory.Core.Orders.Commands
{
    public class PlaceOrder : BaseCommand
    {
        public PlaceOrder(Guid id)
        {
            if (id == Guid.Empty || ReferenceEquals(id, null)) throw new ArgumentException("Invalid Id");

            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
