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
                            VaccinTypeId = new Guid("e0b80ec0-5f8f-4afd-b42e-b4b82e19aaf1"),
                            Name = "BioNTech, Pfizer"
                        },
                        new
                        {
                            VaccinTypeId = new Guid("360da854-3053-4301-a674-dd77c27fc080"),
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
                            VaccinationLocationId = new Guid("80ff9490-6bc6-49dc-9691-d63d31821936"),
                            Name = "Kortrijk Expo"
                        },
                        new
                        {
                            VaccinationLocationId = new Guid("1867d3df-a0dc-4c87-9aa5-1329336b4bc7"),
                            Name = "Vaccinarium Brugge"
                        },
                        new
                        {
                            VaccinationLocationId = new Guid("518dc1c9-b34a-4f47-ab46-0d4bc1b3868e"),
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

                    b.HasIndex("VaccinTypeId");

                    b.ToTable("VaccinationRegistrations");
                });

            modelBuilder.Entity("RegistrationAPI.Models.VaccinationRegistration", b =>
                {
                    b.HasOne("RegistrationAPI.Models.VaccinType", "VaccinType")
                        .WithMany()
                        .HasForeignKey("VaccinTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaccinType");
                });
#pragma warning restore 612, 618
        }
    }
}
