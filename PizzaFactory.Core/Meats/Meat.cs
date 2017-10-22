namespace PizzaFactory.Core.Meats
{
    public abstract class Meat : Topping
    {
        public Meat()
        {
            Type = ToppingType.Meat;
        }
    }
}
