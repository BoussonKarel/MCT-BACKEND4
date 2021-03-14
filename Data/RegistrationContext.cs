using System.Threading;
using System;
using MCT_BACKEND4.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RegistrationAPI.Models;
using System.Threading.Tasks;

namespace MCT_BACKEND4.Data
{
    public interface IRegistrationContext
    {
        DbSet<VaccinType> VaccinTypes { get; set; }
        DbSet<VaccinationRegistration> VaccinationRegistrations { get; set; }
        DbSet<VaccinationLocation> VaccinationLocations { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public class RegistrationContext : DbContext, IRegistrationContext
    {
        public DbSet<VaccinType> VaccinTypes { get; set; }
        public DbSet<VaccinationRegistration> VaccinationRegistrations { get; set; }
        public DbSet<VaccinationLocation> VaccinationLocations { get; set; }

        private ConnectionStrings _connectionStrings;

        public RegistrationContext(DbContextOptions<RegistrationContext> options, IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Locaties
            modelBuilder.Entity<VaccinationLocation>().HasData(new VaccinationLocation()
            {
                VaccinationLocationId = Guid.NewGuid(),
                Name = "Kortrijk Expo"
            });
            modelBuilder.Entity<VaccinationLocation>().HasData(new VaccinationLocation()
            {
                VaccinationLocationId = Guid.NewGuid(),
                Name = "Vaccinarium Brugge"
            });
            modelBuilder.Entity<VaccinationLocation>().HasData(new VaccinationLocation()
            {
                VaccinationLocationId = Guid.NewGuid(),
                Name = "De Penta"
            });

            // VaccinTypes
            modelBuilder.Entity<VaccinType>().HasData(new VaccinType()
            {
                VaccinTypeId = Guid.NewGuid(),
                Name = "BioNTech, Pfizer"
            });

            modelBuilder.Entity<VaccinType>().HasData(new VaccinType()
            {
                VaccinTypeId = Guid.NewGuid(),
                Name = "Spoetnik"
            });
        }
    }
}