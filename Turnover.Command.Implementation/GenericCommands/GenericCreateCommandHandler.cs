using Turnover.Command.Contract;
using Turnover.Command.Contract.GenericCommands;
using Turnover.EntityFramework;

namespace Turnover.Command.Implementation.GenericCommands
{
    public class GenericCreateCommandHandler<TEntity>: ICommandHandler<IGenericCreateCommand<TEntity>> where TEntity: class
    {
        private readonly TurnoverDbContext _context;

        public GenericCreateCommandHandler(TurnoverDbContext context)
        {
            _context = context;
        }

        public void Handle(IGenericCreateCommand<TEntity> command)
        {
            _context.Set<TEntity>().Add(command.Entity);
        }
    }
}