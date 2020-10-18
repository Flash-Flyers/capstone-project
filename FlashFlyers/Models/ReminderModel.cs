using System;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class ReminderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
