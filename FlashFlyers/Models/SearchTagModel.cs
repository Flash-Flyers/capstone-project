using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class SearchTagModel
    {
        [Key]
        public string tag { get; set; }
        public List<int> event_id { get; set; }
    }
}
