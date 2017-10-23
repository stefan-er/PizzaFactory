using PizzaFactory.Core.Cheeses;
using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Meats;
using PizzaFactory.Core.Pizzas;
using PizzaFactory.Core.Sauces;
using PizzaFactory.Core.Vegetables;
using System.Collections.Generic;

namespace PizzaFactory.Web.Models
{
    public class PlaceOrderModel
    {
        public PizzaSize Size { get; set; }
        public DoughType DoughType { get; set; }
        public SauceType SauceType { get; set; }
        public IEnumerable<CheeseType> Cheeses { get; set; }
        public IEnumerable<MeatType> Meats { get; set; }
        public IEnumerable<VegetableType> Vegetables { get; set; }
    }
}
