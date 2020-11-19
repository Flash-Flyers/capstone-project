using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class UserDataModel
    {
        public string Id { get; set; }
        public List<int> event_id { get; set; }
    }
}
