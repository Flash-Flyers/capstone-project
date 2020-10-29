using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlashFlyers.Models
{
    public class LocationModel
    {
        //public int Id { get; set; }
        [Key]
        public string Building { get; set; }
        //public string Campus { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
