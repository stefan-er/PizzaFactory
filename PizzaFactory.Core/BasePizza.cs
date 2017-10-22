using PizzaFactory.Infrastructure;

namespace PizzaFactory.Core
{
    public abstract class BasePizza : EntityBase<int>
    {
        public BasePizza(int id, SauceBase sauce) 
            : base(id)
        {
            this.Sauce = sauce;
        }

        public SauceBase Sauce { get; set; }
    }
}
