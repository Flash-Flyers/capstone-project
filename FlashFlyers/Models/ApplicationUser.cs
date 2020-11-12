using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashFlyers.Models
{
    //this is to extend and add variables to user accounts
    public class ApplicationUser : IdentityUser
    {
        public List<string> Likes { get; set; }
    }
}
