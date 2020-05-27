
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaApp.Dal
{
    public class CoronaContext:DbContext
    {
        public CoronaContext()
      
        {
        }
        public CoronaContext(DbContextOptions<CoronaContext> options)
          : base(options)
        {

        }

        public DbSet<Location> Location { get; set; }
        public DbSet<Patient> Patient { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        if (!optionsBuilder.IsConfigured)
         {
          optionsBuilder.UseSqlServer("Server=ILRLEMBERGERLT;Database=PersonCorona;Trusted_Connection=True;");
         }
}

    }
}
