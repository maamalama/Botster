using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Botster.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Bot> Bots { get; set; }  = new HashSet<Bot>();
    }
}