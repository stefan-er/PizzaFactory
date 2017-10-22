namespace PizzaFactory.Core.Cheeses
{
    public abstract class Cheese : Topping
    {
        public Cheese()
        {
            Type = ToppingType.Cheese;
        }
    }
}
