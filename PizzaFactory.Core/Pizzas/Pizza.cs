using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Sauces;
using System;

namespace PizzaFactory.Core.Pizzas
{
    public abstract class Pizza
    {
        public Pizza()
        {
        }

        public Pizza(Dough dough, Sauce sauce)
            : this()
        {
            Dough = dough;
            Sauce = sauce;
        }

        public PizzaSize Size { get; protected set; }
        public Dough Dough { get; protected set; }
        public Sauce Sauce { get; protected set; }
        
        public virtual string GetIngredients()
        {
            string ingredients = $"Pizza size: {Size.ToString()}{Environment.NewLine}Dough: {Dough.Name}{Environment.NewLine}Sauce: {Sauce.Name}";

            return ingredients;
        }
    }
}
