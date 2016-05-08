using Turnover.Command.Contract.GenericCommands;

namespace Turnover.Command.Implementation.GenericCommands
{
    public class GenericCreateCommand<TEntity> : IGenericCreateCommand<TEntity> where TEntity : class
    {
        public GenericCreateCommand(TEntity entity)
        {
            Entity = entity;
        }

        public TEntity Entity { get; }
    }
}