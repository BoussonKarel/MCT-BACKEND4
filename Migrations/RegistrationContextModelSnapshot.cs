﻿// <auto-generated />
using System;
using MCT_BACKEND4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RegistrationAPI.Migrations
{
    [DbContext(typeof(RegistrationContext))]
    partial class RegistrationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("RegistrationAPI.Models.VaccinType", b =>
                {
                    b.Property<Guid>("VaccinTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaccinTypeId");

                    b.ToTable("VaccinType");

                    b.HasData(
                        new
                        {
                            VaccinTypeId = new Guid("8c9aa10a-f036-496c-9bb6-63d85879c8d6"),
                            Name = "BioNTech, Pfizer"
                        },
                        new
                        {
                            VaccinTypeId = new Guid("a69cdb1a-197d-4476-b7d6-913d05440ad1"),
                            Name = "Spoetnik"
                        });
                });

            modelBuilder.Entity("RegistrationAPI.Models.VaccinationLocation", b =>
                {
                    b.Property<Guid>("VaccinationLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaccinationLocationId");

                    b.ToTable("VaccinationLocations");

                    b.HasData(
                        new
                        {
                            VaccinationLocationId = new Guid("998b6362-54f2-4736-8427-757dc778f10c"),
                            Name = "Kortrijk Expo"
                        },
                        new
                        {
                            VaccinationLocationId = new Guid("56fbee15-61c8-47be-9b82-db12278841b9"),
                            Name = "Vaccinarium Brugge"
                        },
                        new
                        {
                            VaccinationLocationId = new Guid("3b21b0c3-b961-4d5f-ae81-c6f0bf9877a5"),
                            Name = "De Penta"
                        });
                });

            modelBuilder.Entity("RegistrationAPI.Models.VaccinationRegistration", b =>
                {
                    b.Property<Guid>("VaccinationRegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VaccinTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VaccinationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VaccinationLocationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VaccinationRegistrationId");

                    b.ToTable("VaccinationRegistrations");
                });
#pragma warning restore 612, 618
        }
    }
}