namespace PizzaFactory.Infrastructure
{
    public abstract class ApplicationService
    {
        public IRepository Repository { get; set; }
    }
}
