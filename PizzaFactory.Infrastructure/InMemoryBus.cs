using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PizzaFactory.Infrastructure
{
    public class InMemoryBus : ICommandSender, IEventPublisher
    {
        private IDictionary<Type, List<Type>> handlerTypes;
        private Func<Type, object> handlerFactory;

        public InMemoryBus(Func<Type, object> handlerFactory, params Assembly[] hanlersAssemblies)
        {
            this.handlerTypes = new Dictionary<Type, List<Type>>();
            this.handlerFactory = handlerFactory;

            foreach (Assembly assembly in hanlersAssemblies)
            {
                IEnumerable<Type> handlers = assembly.GetTypes()
                    .Where(x => x.GetInterfaces().Any(i => i.IsGenericType && (i.GetGenericTypeDefinition() == typeof(IEventHandler<>) || i.GetGenericTypeDefinition() == typeof(ICommandHandler<>))));

                foreach (Type handler in handlers)
                {
                    IEnumerable<Type> interfaces = handler.GetInterfaces()
                        .Where(i => i.IsGenericType && (i.GetGenericTypeDefinition() == typeof(IEventHandler<>) || i.GetGenericTypeDefinition() == typeof(ICommandHandler<>)));

                    foreach (Type @interface in interfaces)
                    {
                        Type messageType = @interface.GetGenericArguments().First();

                        if (!handlerTypes.ContainsKey(messageType))
                            handlerTypes[messageType] = new List<Type>();

                        handlerTypes[messageType].Add(handler);
                    }
                }
            }
        }

        public void Send(ICommand command)
        {
            PublishMessage(command);
        }
        public void Publish(IEvent @event)
        {
            PublishMessage(@event);
        }

        private void PublishMessage(IMessage message)
        {
            Type messageType = message.GetType();
            if (handlerTypes.ContainsKey(messageType))
            {
                foreach (Type handlerType in handlerTypes[messageType])
                {
                    object handler = handlerFactory(handlerType);
                    ((dynamic)handler).Handle((dynamic)message);
                }
            }
        }
    }
}
