using PizzaFactory.Infrastructure;

namespace PizzaFactory.Core.Common
{
    public class BaseEvent : IEvent
    {
        public BaseEvent(string calledBy)
        {
            CalledBy = calledBy;
        }

        public string CalledBy { get; private set; }
    }
}
