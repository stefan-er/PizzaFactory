using PizzaFactory.Core.Doughs;
using PizzaFactory.Core.Sauces;

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

        public PizzaSize Type { get; protected set; }
        public Dough Dough { get; protected set; }
        public Sauce Sauce { get; protected set; }
        
        public virtual string GetIngredients()
        {
            string ingredients = $"Pizza type: {Type.ToString()}\\r\\nDough: {Dough.Name}\\r\\nSauce: {Sauce.Name}";

            return ingredients;
        }
    }
}
