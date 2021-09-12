using Microsoft.EntityFrameworkCore;

namespace Botster.Core.Database
{
    public class BotsterContext : DbContext
    {
        public BotsterContext(DbContextOptions<BotsterContext> options) : base(options)
        {
            
        }
    }
}