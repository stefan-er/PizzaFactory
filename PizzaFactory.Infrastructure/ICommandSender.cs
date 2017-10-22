﻿namespace PizzaFactory.Infrastructure
{
    public interface ICommandSender
    {
        void Send<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
