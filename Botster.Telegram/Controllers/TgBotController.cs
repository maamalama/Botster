using System.Threading.Tasks;
using Botster.Telegram.TelegramService.Commands.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Botster.Telegram.Controllers
{
    [ApiController]
    [Route("api/message/update")]
    public class TgBotController : Controller
    {
        private readonly ITelegramBotClient _telegramBotClient;
        private readonly ITelegramService _telegramService;

        public TgBotController(
            ITelegramBotClient telegramBotClient, 
            ITelegramService telegramService)
        {
            _telegramBotClient = telegramBotClient;
            _telegramService = telegramService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Bot started");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            if (update == null) return Ok();

            var message = update.Message;

            await _telegramService.ExecuteCommand(message);
            return Ok();
        }
    }
}