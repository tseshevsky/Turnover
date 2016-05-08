using System.Data.Entity;
using Turnover.Command.Contract;
using Turnover.Command.Contract.GenericCommands;
using Turnover.EntityFramework;

namespace Turnover.Command.Implementation.GenericCommands
{
    public class GenericUpdateCommandHandler<TEntity> : ICommandHandler<IGenericUpdateCommand<TEntity>> where TEntity : class
    {
        private readonly TurnoverDbContext _context;

        public GenericUpdateCommandHandler(TurnoverDbContext context)
        {
            _context = context;
        }

        public void Handle(IGenericUpdateCommand<TEntity> command)
        {
            _context.Set<TEntity>().Attach(command.Entity);
            _context.Entry(command.Entity).State = EntityState.Modified;
        }
    }
}