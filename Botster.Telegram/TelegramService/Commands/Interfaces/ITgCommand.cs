using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Botster.Telegram.TelegramService.Commands.Interfaces
{
    public interface ITgCommand
    {
        public Task Execute(Message message, ITelegramBotClient client);
    }
}