namespace PizzaFactory.Infrastructure
{
    public interface IEventPublisher
    {
        void Publish(IEvent @event);
    }
}
