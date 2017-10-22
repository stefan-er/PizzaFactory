﻿namespace PizzaFactory.Core
{
    public abstract class Topping
    {
        public string Name { get; protected set; }
        public ToppingType Type { get; protected set; }
    }
}
