namespace Turnover.Command.Contract
{
    public interface ICommandHandler<in TCommand>
    {
        void Handle(TCommand command);
    }
}