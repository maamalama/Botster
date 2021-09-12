using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Botster.Telegram.TelegramService.Commands;
using Botster.Telegram.TelegramService.Commands.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Botster.Telegram.TelegramService
{
    public class TelegramService : ITelegramService
    {
        private readonly Dictionary<string,ITgCommand> _commands;
        private readonly ITelegramBotClient _telegramBotClient;

        public TelegramService(ITelegramBotClient telegramBotClient)
        {
            _telegramBotClient = telegramBotClient;
            _commands = new Dictionary<string,ITgCommand>
            {
                {"\U0001F4D6 Помощь", new HelpCommand()},
                {@"/start",new StartCommand()}
            };
        }

        public async Task ExecuteCommand(Message message)
        {
            await ExecuteAsync(message);
        }

        private async Task ExecuteAsync(Message message)
        {
            var exCommand = message.Type switch
            {
                MessageType.Text => _commands[message.Text].Execute(message, _telegramBotClient),
                _ => Task.CompletedTask
            };

            await exCommand;
        }
    }
}