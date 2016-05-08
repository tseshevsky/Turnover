using Turnover.Command.Contract.GenericCommands;

namespace Turnover.Command.Implementation.GenericCommands
{
    public class GenericUpdateCommand<TEntity> : IGenericUpdateCommand<TEntity> where TEntity : class
    {
        public GenericUpdateCommand(TEntity entity)
        {
            Entity = entity;
        }

        public TEntity Entity { get; }
    }
}