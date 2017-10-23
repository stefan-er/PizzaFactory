using PizzaFactory.Core.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory.Core.PizzaDecorators
{
    public abstract class PizzaDecorator<T> : Pizza
        where T : Topping
    {
        public PizzaDecorator(Pizza pizza, params Topping[] toppings)
        {
            Pizza = pizza;

            Size = pizza.Size;
            Dough = pizza.Dough;
            Sauce = pizza.Sauce;
            
            Toppings = new HashSet<Topping>();

            AddToppings(toppings);
        }

        protected Pizza Pizza { get; private set; }
        protected ICollection<Topping> Toppings { get; private set; }
        protected ToppingType ToppingType { get; set; }

        public override string GetIngredients()
        {
            var ingredientsBuilder = new StringBuilder();

            ingredientsBuilder.Append(Pizza.GetIngredients());
            ingredientsBuilder.Append($"{Environment.NewLine}{ToppingType.ToString()}: ");

            foreach (Topping topping in Toppings)
            {
                ingredientsBuilder.Append($"{Environment.NewLine}    {topping.Name}");
            }

            return ingredientsBuilder.ToString();
        }

        private void AddToppings(IEnumerable<Topping> toppings)
        {
            foreach (Topping topping in toppings)
            {
                Toppings.Add(topping);
            }
        }
    }
}
