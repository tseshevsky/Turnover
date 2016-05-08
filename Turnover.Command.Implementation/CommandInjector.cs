using SimpleInjector;
using System.Reflection;
using Turnover.Command.Contract;
using Turnover.Command.Implementation.Decorators;

namespace Turnover.Command.Implementation
{
    public class CommandInjector
    {
        public void Register(Container container)
        {
            // Go look in all assemblies and register all implementations
            // of ICommandHandler<T> by their closed interface:
            container.Register(
                typeof(ICommandHandler<>),
                new[] { typeof(ICommandHandler<>).GetTypeInfo().Assembly });

            // Decorate each returned ICommandHandler<T> object with
            // a TransactionCommandHandlerDecorator<T>.
            container.RegisterDecorator(
                typeof(ICommandHandler<>),
                typeof(TransactionCommandHandlerDecorator<>));

            // Decorate each returned ICommandHandler<T> object with
            // a DeadlockRetryCommandHandlerDecorator<T>.
            container.RegisterDecorator(
                typeof(ICommandHandler<>),
                typeof(DeadlockRetryCommandHandlerDecorator<>));
        }
    }
}
