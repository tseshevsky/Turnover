using System;

namespace Turnover.Command.Contract.GenericCommands
{
    public interface IGenericDeleteCommand<TEntity> where TEntity : class
    {
        Guid Id { get; }
    }
}