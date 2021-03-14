using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAPI.Migrations
{
    public partial class nvm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VaccinType",
                keyColumn: "VaccinTypeId",
                keyValue: new Guid("3aff3459-ca61-49f4-b67e-0860c33402ff"));

            migrationBuilder.DeleteData(
                table: "VaccinType",
                keyColumn: "VaccinTypeId",
                keyValue: new Guid("c75cdefe-ae87-4e03-bce4-b29d6d12231b"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("70971858-5e25-463c-bea0-cb4ae8a9a387"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("d45e47e6-437d-4d72-9cc8-00cbec02d5e6"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("e369ce87-8fa4-4a3c-bdb4-8910f7567ab3"));

            migrationBuilder.InsertData(
                table: "VaccinType",
                columns: new[] { "VaccinTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("e0b80ec0-5f8f-4afd-b42e-b4b82e19aaf1"), "BioNTech, Pfizer" },
                    { new Guid("360da854-3053-4301-a674-dd77c27fc080"), "Spoetnik" }
                });

            migrationBuilder.InsertData(
                table: "VaccinationLocations",
                columns: new[] { "VaccinationLocationId", "Name" },
                values: new object[,]
                {
                    { new Guid("80ff9490-6bc6-49dc-9691-d63d31821936"), "Kortrijk Expo" },
                    { new Guid("1867d3df-a0dc-4c87-9aa5-1329336b4bc7"), "Vaccinarium Brugge" },
                    { new Guid("518dc1c9-b34a-4f47-ab46-0d4bc1b3868e"), "De Penta" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VaccinType",
                keyColumn: "VaccinTypeId",
                keyValue: new Guid("360da854-3053-4301-a674-dd77c27fc080"));

            migrationBuilder.DeleteData(
                table: "VaccinType",
                keyColumn: "VaccinTypeId",
                keyValue: new Guid("e0b80ec0-5f8f-4afd-b42e-b4b82e19aaf1"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("1867d3df-a0dc-4c87-9aa5-1329336b4bc7"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("518dc1c9-b34a-4f47-ab46-0d4bc1b3868e"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("80ff9490-6bc6-49dc-9691-d63d31821936"));

            migrationBuilder.InsertData(
                table: "VaccinType",
                columns: new[] { "VaccinTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("3aff3459-ca61-49f4-b67e-0860c33402ff"), "BioNTech, Pfizer" },
                    { new Guid("c75cdefe-ae87-4e03-bce4-b29d6d12231b"), "Spoetnik" }
                });

            migrationBuilder.InsertData(
                table: "VaccinationLocations",
                columns: new[] { "VaccinationLocationId", "Name" },
                values: new object[,]
                {
                    { new Guid("e369ce87-8fa4-4a3c-bdb4-8910f7567ab3"), "Kortrijk Expo" },
                    { new Guid("70971858-5e25-463c-bea0-cb4ae8a9a387"), "Vaccinarium Brugge" },
                    { new Guid("d45e47e6-437d-4d72-9cc8-00cbec02d5e6"), "De Penta" }
                });
        }
    }
}
