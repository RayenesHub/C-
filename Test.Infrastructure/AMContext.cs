using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Test.ApplicationCore.Domain;
using Test.Infrastructure.Configuration;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=WIOUW;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PrestationConfig());
            //modelBuilder.ApplyConfiguration(new FlightConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Staff>().ToTable("Staffs");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            //base.ConfigureConventions(configurationBuilder);
        }



        public DbSet<Client> Clients { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }



    }

}
