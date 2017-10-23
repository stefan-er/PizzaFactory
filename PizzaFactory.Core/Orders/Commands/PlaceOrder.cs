using PizzaFactory.Core.Cheeses;
using PizzaFactory.Core.Common;
using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Meats;
using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Sauces;
using PizzaFactory.Core.Vegetables;
using System;
using System.Collections.Generic;

namespace PizzaFactory.Core.Orders.Commands
{
    public class PlaceOrder : BaseCommand
    {
        public PlaceOrder(Guid id, PizzaSize size, DoughType doughType, SauceType sauceType, 
            IEnumerable<CheeseType> cheeses, IEnumerable<MeatType> meats, IEnumerable<VegetableType> vegetables, 
            string calledBy): base(calledBy)
        {
            if (id == Guid.Empty || ReferenceEquals(id, null)) throw new ArgumentException("Invalid Id");

            Id = id;
            Size = size;
            DoughType = doughType;
            SauceType = sauceType;
            Cheeses = cheeses;
            Meats = meats;
            Vegetables = vegetables;
        }

        public Guid Id { get; private set; }
        public PizzaSize Size { get; private set; }
        public DoughType DoughType { get; private set; }
        public SauceType SauceType { get; private set; }
        public IEnumerable<CheeseType> Cheeses { get; private set; }
        public IEnumerable<MeatType> Meats { get; private set; }
        public IEnumerable<VegetableType> Vegetables { get; private set; }
    }
}
