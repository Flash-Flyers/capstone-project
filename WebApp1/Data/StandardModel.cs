using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp1.Data
{
    public class StandardModel : IdentityDbContext
    {
        public StandardModel(DbContextOptions<StandardModel> options)
            : base(options)
        {
        }
    }
}
