namespace Turnover.Command.Contract.GenericCommands
{
    public interface IGenericUpdateCommand<out TEntity> where TEntity: class 
    {
        TEntity Entity { get; }
    }
}