using System.Threading.Tasks;

namespace Botster.Core.Communication
{
    public interface IBaseCommand
    {
        string Name { get; }
    }
}