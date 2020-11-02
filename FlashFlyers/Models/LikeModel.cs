using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FlashFlyers.Models
{
    public class LikeModel
    {
        [Key]
        public int LikeId { get; set; }
        [ForeignKey("EventModel")]
        public int EventId { get; set; } //Event ID number
        [ForeignKey("AccountModel")]
        public string Email { get; set; }
    }
}
