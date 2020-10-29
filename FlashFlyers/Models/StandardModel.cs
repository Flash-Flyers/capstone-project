using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class StandardModel : IdentityDbContext
    {
        public StandardModel(DbContextOptions<StandardModel> options) : base(options) { }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<LocationModel> Locations { get; set; }
        //public object EventModel { get; internal set; }
        //public object LocationModel { get; internal set; }
    }
}