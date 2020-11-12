using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class EmailReminderModel
    {
        [Key]
        public int EmailReminderId { get; set; }
        public int EventId { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
    }
}
