using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAPI.Migrations
{
    public partial class testinclude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VaccinType",
                keyColumn: "VaccinTypeId",
                keyValue: new Guid("15469f07-e61f-42e5-8bc3-fb9a84531f4a"));

            migrationBuilder.DeleteData(
                table: "VaccinType",
                keyColumn: "VaccinTypeId",
                keyValue: new Guid("6ee76ca4-dc0c-411d-b351-9a7a8c087562"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("30eb8f30-24f6-4048-bd42-d067ac8b466e"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("444b1a8e-e307-4d28-b578-8bc28432053c"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("ae77c2c3-7c69-4dd1-a5d4-00e34fe0f7ac"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("15469f07-e61f-42e5-8bc3-fb9a84531f4a"), "BioNTech, Pfizer" },
                    { new Guid("6ee76ca4-dc0c-411d-b351-9a7a8c087562"), "Spoetnik" }
                });

            migrationBuilder.InsertData(
                table: "VaccinationLocations",
                columns: new[] { "VaccinationLocationId", "Name" },
                values: new object[,]
                {
                    { new Guid("30eb8f30-24f6-4048-bd42-d067ac8b466e"), "Kortrijk Expo" },
                    { new Guid("ae77c2c3-7c69-4dd1-a5d4-00e34fe0f7ac"), "Vaccinarium Brugge" },
                    { new Guid("444b1a8e-e307-4d28-b578-8bc28432053c"), "De Penta" }
                });
        }
    }
}
