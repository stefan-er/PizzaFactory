using PizzaFactory.Infrastructure;

namespace PizzaFactory.Core.Common
{
    public class BaseCommand : ICommand
    {
        public BaseCommand(string calledBy)
        {
            CalledBy = calledBy;
        }

        public string CalledBy { get; private set; }
    }
}
