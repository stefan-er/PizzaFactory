namespace PizzaFactory.Infrastructure
{
    public abstract class ApplicationService
    {
        public ApplicationService(IRepository repository)
        {
            Repository = repository;
        }

        public IRepository Repository { get; set; }
    }
}
