using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace clinicSystem.data
{
    public class ClinicContext : DbContext
    {
        public DbSet<Patient> patients { get; set; }
        public DbSet<Country> country { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;initial catalog=ClinicDb;Integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
