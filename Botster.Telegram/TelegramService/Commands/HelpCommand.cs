using System.Threading.Tasks;
using Botster.Telegram.TelegramService.Commands.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Botster.Telegram.Keyboard;

namespace Botster.Telegram.TelegramService.Commands
{
    public class HelpCommand : ITgCommand
    {
        public string Name => "\U0001F4D6 Помощь";
        public async Task Execute(Message message, ITelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            await client.SendTextMessageAsync(chatId, "\U0001F4D6 Помощь",
                parseMode: ParseMode.Markdown, replyMarkup: BotKeyboards.TgKeyboard);
        }

        public bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }
    }
}