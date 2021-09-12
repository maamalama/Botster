using System.Threading.Tasks;
using Botster.Telegram.TelegramService.Commands.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Botster.Telegram.TelegramService.Commands
{
    public class StartCommand : ITgCommand
    {
        public string Name => @"/start";
        public async Task Execute(Message message, ITelegramBotClient client)
        {
            var chatId = message.Chat.Id;

            var keyBoard = new ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new[]
                    {
                        new KeyboardButton("\U0001F3E0 Главная")
                    },
                    new[]
                    {
                        new KeyboardButton("\U00012705 Заметка")
                    },
                    new []
                    {
                        new KeyboardButton("\U0001F45C Профиль")
                    },
                    new []
                    {
                        new KeyboardButton("\U0001F4D6 Помощь") 
                    }
                }
            };
            await client.SendTextMessageAsync(chatId, "Привет! Используй функционал бота чтобы добавить заметку",
                parseMode: ParseMode.Html, null, false, false, 0,false, keyBoard);
        }

        public bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }
    }
}