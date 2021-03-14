using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAPI.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VaccinationLocations",
                columns: table => new
                {
                    VaccinationLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationLocations", x => x.VaccinationLocationId);
                });

            migrationBuilder.CreateTable(
                name: "VaccinTypes",
                columns: table => new
                {
                    VaccinTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinTypes", x => x.VaccinTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationRegistrations",
                columns: table => new
                {
                    VaccinationRegistrationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    VaccinationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaccinTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VaccinationLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationRegistrations", x => x.VaccinationRegistrationId);
                    table.ForeignKey(
                        name: "FK_VaccinationRegistrations_VaccinTypes_VaccinTypeId",
                        column: x => x.VaccinTypeId,
                        principalTable: "VaccinTypes",
                        principalColumn: "VaccinTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VaccinTypes",
                columns: new[] { "VaccinTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("6439d094-1ae8-4955-a870-26d4c226fe31"), "BioNTech, Pfizer" },
                    { new Guid("80b85b82-466d-4206-8933-ab568d099739"), "Spoetnik" }
                });

            migrationBuilder.InsertData(
                table: "VaccinationLocations",
                columns: new[] { "VaccinationLocationId", "Name" },
                values: new object[,]
                {
                    { new Guid("6c371d77-1e54-40aa-b453-c32f296bdf41"), "Kortrijk Expo" },
                    { new Guid("444b7960-dc17-44bf-bbf9-4dd6970e871b"), "Vaccinarium Brugge" },
                    { new Guid("c8992af9-307e-486a-8ee4-25e8e7fa6396"), "De Penta" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationRegistrations_VaccinTypeId",
                table: "VaccinationRegistrations",
                column: "VaccinTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VaccinationLocations");

            migrationBuilder.DropTable(
                name: "VaccinationRegistrations");

            migrationBuilder.DropTable(
                name: "VaccinTypes");
        }
    }
}
