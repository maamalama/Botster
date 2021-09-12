using System;

namespace Botster.WebApp.Models
{
    public class Bot
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public BotType BotType { get; set; }
        public string ApiKey { get; set; }
    }
}