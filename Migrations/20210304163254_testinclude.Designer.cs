﻿// <auto-generated />
using System;
using MCT_BACKEND4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RegistrationAPI.Migrations
{
    [DbContext(typeof(RegistrationContext))]
    [Migration("20210304163254_testinclude")]
    partial class testinclude
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            VaccinTypeId = new Guid("3aff3459-ca61-49f4-b67e-0860c33402ff"),
                            Name = "BioNTech, Pfizer"
                        },
                        new
                        {
                            VaccinTypeId = new Guid("c75cdefe-ae87-4e03-bce4-b29d6d12231b"),
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
                            VaccinationLocationId = new Guid("e369ce87-8fa4-4a3c-bdb4-8910f7567ab3"),
                            Name = "Kortrijk Expo"
                        },
                        new
                        {
                            VaccinationLocationId = new Guid("70971858-5e25-463c-bea0-cb4ae8a9a387"),
                            Name = "Vaccinarium Brugge"
                        },
                        new
                        {
                            VaccinationLocationId = new Guid("d45e47e6-437d-4d72-9cc8-00cbec02d5e6"),
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
                        .WithMany("VaccinationRegistration")
                        .HasForeignKey("VaccinTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaccinType");
                });

            modelBuilder.Entity("RegistrationAPI.Models.VaccinType", b =>
                {
                    b.Navigation("VaccinationRegistration");
                });
#pragma warning restore 612, 618
        }
    }
}
