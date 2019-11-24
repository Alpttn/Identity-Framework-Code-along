using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityIntro.Models
{
    //already has an Id
    public class ApplicationUser : IdentityUser
    {
        public string SlackHandle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
