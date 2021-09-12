using System.Threading.Tasks;

namespace Botster.Core.Communication.Processor
{
    public abstract class CommandProcessor<TCommand> : ICommandProcessor<TCommand> where TCommand : IBaseCommand
    {
        public abstract Task<Content> ProcessCommand(TCommand command);
    }
}