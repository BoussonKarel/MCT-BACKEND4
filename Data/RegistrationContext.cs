using System;
using MCT_BACKEND4.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RegistrationAPI.Models;

namespace MCT_BACKEND4.Data
{
    public class RegistrationContext : DbContext
    {
        public DbSet<VaccinType> VaccinType { get; set; }
        public DbSet<VaccinationRegistration> VaccinationRegistrations { get;set; }
        public DbSet<VaccinationLocation> VaccinationLocations { get; set; }

        private ConnectionStrings _connectionStrings;

        public RegistrationContext(DbContextOptions<RegistrationContext> options, IOptions<ConnectionStrings> connectionStrings) {
            _connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer(_connectionStrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // Locaties
            modelBuilder.Entity<VaccinationLocation>().HasData(new VaccinationLocation() {
                VaccinationLocationId = Guid.NewGuid(), Name = "Kortrijk Expo"
            });
            modelBuilder.Entity<VaccinationLocation>().HasData(new VaccinationLocation() {
                VaccinationLocationId = Guid.NewGuid(), Name = "Vaccinarium Brugge"
            });
            modelBuilder.Entity<VaccinationLocation>().HasData(new VaccinationLocation() {
                VaccinationLocationId = Guid.NewGuid(), Name = "De Penta"
            });

            // VaccinTypes
            modelBuilder.Entity<VaccinType>().HasData(new VaccinType() {
                VaccinTypeId = Guid.NewGuid(), Name = "BioNTech, Pfizer"
            });

            modelBuilder.Entity<VaccinType>().HasData(new VaccinType() {
                VaccinTypeId = Guid.NewGuid(), Name = "Spoetnik"
            });
        }
    }
}