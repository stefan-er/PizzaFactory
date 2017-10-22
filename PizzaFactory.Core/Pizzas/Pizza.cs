using PizzaFactory.Infrastructure;

namespace PizzaFactory.Core
{
    public abstract class Pizza : EntityBase<int>
    {
        public Pizza(int id, Sauce sauce) 
            : base(id)
        {
            this.Sauce = sauce;
        }

        public Sauce Sauce { get; set; }
    }
}
