using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashFlyers.Models
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string Building { get; set; }
        public string Campus { get; set; }
        public float latitude { get; set; }
        public float longitute { get; set; }
    }
}
