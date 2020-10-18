using System;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
    }
}
