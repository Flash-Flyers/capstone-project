using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashFlyers.Models
{
    public class EventModel
    {
        public int Id { get; set; } //Event ID number
        public string Title { get; set; } //Event Title
        public string Description { get; set; } //Event Description
        public string FileName { get; set; } //Cover Image file
        public string Date { get; set; } //Date of the event
        public string Time { get; set; } //Time of the event
        public string Building { get; set; } //Building where event is held
        public int Room { get; set; } //Room number of event if applicable
        //public string Campus { get; set; } //Campus where event is held
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int Likes { get; set; }
    }
}
