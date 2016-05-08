using System;
using Turnover.Command.Contract.GenericCommands;

namespace Turnover.Command.Implementation.GenericCommands
{
    public class GenericDeleteCommand<TEntity> : IGenericDeleteCommand<TEntity> where TEntity : class
    {
        public GenericDeleteCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}