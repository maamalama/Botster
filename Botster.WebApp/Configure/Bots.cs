using System.Collections.Generic;
using Botster.WebApp.Models;

namespace Botster.WebApp.Configure
{
    public class Bots
    {
        public HashSet<Bot> BotList { get; set; }  = new HashSet<Bot>();
    }
}