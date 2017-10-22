﻿using PizzaFactory.Core.Pizzas;
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

            Type = pizza.Type;
            Dough = pizza.Dough;
            Sauce = pizza.Sauce;
            
            Toppings = new HashSet<Topping>();

            AddToppings(toppings);
        }

        protected Pizza Pizza { get; private set; }
        protected ICollection<Topping> Toppings { get; private set; }
        protected ToppingType ToppingType { get; private set; }

        public override string GetIngredients()
        {
            var ingredientsBuilder = new StringBuilder();

            ingredientsBuilder.Append(Pizza.GetIngredients());
            ingredientsBuilder.Append($"\\r\\nTODO: Add Topping type: ");

            foreach (Topping topping in Toppings)
            {
                ingredientsBuilder.Append($"\\r\\n    {topping.Name}");
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
