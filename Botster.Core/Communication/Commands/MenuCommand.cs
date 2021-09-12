using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Botster.Core.Communication.Commands
{
    public class MenuCommand : BaseCommand
    {
        public override string Name { get; set; }

        public readonly List<IBaseCommand> Commands = new List<IBaseCommand>
        {
            new HelpCommand()
        };
    }
}