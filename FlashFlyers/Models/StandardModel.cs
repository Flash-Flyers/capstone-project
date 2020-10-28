using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class StandardModel : IdentityDbContext
    {
        public StandardModel(DbContextOptions<StandardModel> options) : base(options) { }
        public DbSet<EventModel> Events { get; set; }

        public DbSet<SearchTagModel> Tags { get; set; }
        public object EventModel { get; internal set; }

        
    }
}