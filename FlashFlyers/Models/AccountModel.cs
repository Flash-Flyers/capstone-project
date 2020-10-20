using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class AccountModel
    {
        [Key]
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Preferences { get; set; }
    }
}
