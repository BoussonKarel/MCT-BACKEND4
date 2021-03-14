using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAPI.Migrations
{
    public partial class model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationRegistrations_VaccinTypeId",
                table: "VaccinationRegistrations",
                column: "VaccinTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationRegistrations_VaccinType_VaccinTypeId",
                table: "VaccinationRegistrations",
                column: "VaccinTypeId",
                principalTable: "VaccinType",
                principalColumn: "VaccinTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationRegistrations_VaccinType_VaccinTypeId",
                table: "VaccinationRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_VaccinationRegistrations_VaccinTypeId",
                table: "VaccinationRegistrations");

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
    }
}
