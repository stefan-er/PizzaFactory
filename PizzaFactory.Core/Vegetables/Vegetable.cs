namespace PizzaFactory.Core.Vegetables
{
    public abstract class Vegetable : Topping
    {
        public Vegetable()
        {
            Type = ToppingType.Vegetable;
        }
    }
}
