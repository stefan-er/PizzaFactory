namespace PizzaFactory.Infrastructure
{
    public interface IEventHandler<TEvent>
        where TEvent : IEvent
    {
        void Handle(IEvent @event);
    }
}
