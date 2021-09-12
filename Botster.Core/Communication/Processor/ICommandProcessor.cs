using System.Threading.Tasks;

namespace Botster.Core.Communication.Processor
{
    public interface ICommandProcessor<TCommand>
        where TCommand : IBaseCommand
    {
        Task<Content> ProcessCommand(TCommand command);
    }
}