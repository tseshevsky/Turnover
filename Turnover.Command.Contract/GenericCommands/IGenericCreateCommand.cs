namespace Turnover.Command.Contract.GenericCommands
{
    public interface IGenericCreateCommand<out TEntity> where TEntity: class 
    {
        TEntity Entity { get; }
    }
}
