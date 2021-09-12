using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Botster.Telegram.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Bot> Bots { get; set; }  = new HashSet<Bot>();
    }
}