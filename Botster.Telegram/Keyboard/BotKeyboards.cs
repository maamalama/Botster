using Telegram.Bot.Types.ReplyMarkups;

namespace Botster.Telegram.Keyboard
{
    public class BotKeyboards
    {
        public static ReplyKeyboardMarkup TgKeyboard => new ReplyKeyboardMarkup
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
    }
}