using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Sauces;
using System.Collections.Generic;

namespace PizzaFactory.Core.Pizzas
{
    public abstract class Pizza
    {
        private IDictionary<string, ICollection<Topping>> toppings;

        public Pizza()
        {
            toppings = new Dictionary<string, ICollection<Topping>>();
        }

        public Pizza(Dough dough, Sauce sauce)
            : this()
        {
            Dough = dough;
            Sauce = sauce;
        }

        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        
        public virtual ICollection<Topping> this[string toppingType]
        {
            get
            {
                if (!this.toppings.ContainsKey(toppingType))
                {
                    this.toppings[toppingType] = new List<Topping>();
                }

                return this.toppings[toppingType];
            }
        }
    }
}
