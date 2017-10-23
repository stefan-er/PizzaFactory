namespace PizzaFactory.Infrastructure
{
    public interface ICommandSender
    {
        void Send(ICommand command);
    }
}
