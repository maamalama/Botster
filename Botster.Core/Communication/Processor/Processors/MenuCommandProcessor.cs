using System.Text.Json;
using System.Threading.Tasks;
using Botster.Core.Communication.Commands;

namespace Botster.Core.Communication.Processor.Processors
{
    public class MenuCommandProcessor : CommandProcessor<MenuCommand>
    {
        public override async Task<Content> ProcessCommand(MenuCommand command)
        {
            var serialize = JsonSerializer.Serialize(command.Commands);
            return new Content
            {
                Value = serialize
            };
        }
    }
}