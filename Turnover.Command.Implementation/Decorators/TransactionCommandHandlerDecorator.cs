using SimpleInjector;
using Turnover.Command.Contract;
using Turnover.EntityFramework;

namespace Turnover.Command.Implementation.Decorators
{
    public class TransactionCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>
    {
        private readonly ICommandHandler<TCommand> _decorated;
        private readonly TurnoverDbContext _context;

        public TransactionCommandHandlerDecorator(ICommandHandler<TCommand> decorated, TurnoverDbContext context)
        {
            _decorated = decorated;
            _context = context;
        }

        public void Handle(TCommand command)
        {
            _decorated.Handle(command);

            _context.SaveChanges();
        }
    }
}