using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAPI.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VaccinType",
                columns: new[] { "VaccinTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("8c9aa10a-f036-496c-9bb6-63d85879c8d6"), "BioNTech, Pfizer" },
                    { new Guid("a69cdb1a-197d-4476-b7d6-913d05440ad1"), "Spoetnik" }
                });

            migrationBuilder.InsertData(
                table: "VaccinationLocations",
                columns: new[] { "VaccinationLocationId", "Name" },
                values: new object[,]
                {
                    { new Guid("998b6362-54f2-4736-8427-757dc778f10c"), "Kortrijk Expo" },
                    { new Guid("56fbee15-61c8-47be-9b82-db12278841b9"), "Vaccinarium Brugge" },
                    { new Guid("3b21b0c3-b961-4d5f-ae81-c6f0bf9877a5"), "De Penta" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VaccinType",
                keyColumn: "VaccinTypeId",
                keyValue: new Guid("8c9aa10a-f036-496c-9bb6-63d85879c8d6"));

            migrationBuilder.DeleteData(
                table: "VaccinType",
                keyColumn: "VaccinTypeId",
                keyValue: new Guid("a69cdb1a-197d-4476-b7d6-913d05440ad1"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("3b21b0c3-b961-4d5f-ae81-c6f0bf9877a5"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("56fbee15-61c8-47be-9b82-db12278841b9"));

            migrationBuilder.DeleteData(
                table: "VaccinationLocations",
                keyColumn: "VaccinationLocationId",
                keyValue: new Guid("998b6362-54f2-4736-8427-757dc778f10c"));
        }
    }
}
