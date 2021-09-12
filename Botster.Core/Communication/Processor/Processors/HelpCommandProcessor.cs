using System.Threading.Tasks;
using Botster.Core.Communication.Commands;

namespace Botster.Core.Communication.Processor.Processors
{
    public class HelpCommandProcessor : CommandProcessor<HelpCommand>
    {
        public override Task<Content> ProcessCommand(HelpCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}