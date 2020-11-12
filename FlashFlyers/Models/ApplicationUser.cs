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
        public ApplicationUser() {
            Likes = new List<string>();
            SavedEvents = new List<int>();
            AuthoredEvents = new List<int>();
        }
        public List<string> Likes { get; set; }
        public List<int> SavedEvents { get; set; }
        public List<int> AuthoredEvents { get; set; }
    }
}
