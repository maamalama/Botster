using System.Threading.Tasks;

namespace Botster.Core.Communication
{
    public abstract class BaseCommand : IBaseCommand
    {
        public abstract string Name { get; set; }
    }
}