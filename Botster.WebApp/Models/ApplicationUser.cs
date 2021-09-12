using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Botster.WebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Bot> Bots { get; set; }  = new HashSet<Bot>();
    }
}