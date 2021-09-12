using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Botster.Telegram.TelegramService.Commands.Interfaces
{
    public interface ITelegramService
    {
        Task ExecuteCommand(Message message);
    }
}