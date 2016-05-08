using Turnover.Command.Contract;
using Turnover.Command.Contract.GenericCommands;
using Turnover.EntityFramework;
using Turnover.PersistentModel;

namespace Turnover.Command.Implementation.GenericCommands
{
    public class GenericDeleteCommandHandler<TEntity> : ICommandHandler<IGenericDeleteCommand<TEntity>> where TEntity : class, IEntity, new()
    {
        private readonly TurnoverDbContext _context;

        public GenericDeleteCommandHandler(TurnoverDbContext context)
        {
            _context = context;
        }

        public void Handle(IGenericDeleteCommand<TEntity> command)
        {
            var entity = new TEntity()
            {
                Id = command.Id
            };
            _context.Set<TEntity>().Remove(entity);
        }
    }
}