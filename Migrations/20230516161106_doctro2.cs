using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SRP.Migrations
{
    public partial class doctro2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("854a2c1d-4ad2-4ce0-af62-8eb2c44be8a4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5397a3e-923b-47ad-9655-71162ab2ded0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fe1d423f-b2cd-4f3d-bc3b-15e6b09ef1f4"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("f5b9d3ac-3916-49cf-8d78-393fa5563374"), new Guid("a5d6f294-4971-4f47-b470-ecf3410a94a1") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5d6f294-4971-4f47-b470-ecf3410a94a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5b9d3ac-3916-49cf-8d78-393fa5563374"));

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Specialisation = table.Column<int>(nullable: false),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    PeopleCount = table.Column<int>(nullable: true),
                    DateEventStart = table.Column<DateTime>(nullable: false),
                    DateEventEnd = table.Column<DateTime>(nullable: true),
                    DateEventRegistrationEnd = table.Column<DateTime>(nullable: false),
                    DateEventRegistractionStart = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("c7b240fe-9f25-4b7d-9390-20b524ef0420"), "f6b7f469-7bd5-4a9e-99cd-8635f06b0261", "Admin", "ADMIN" },
                    { new Guid("ed6e56d7-046b-47d0-8f85-a2d396f97005"), "be9e9f9a-9eba-4f6b-9898-69d49988f578", "Doctor", "DOCTOR" },
                    { new Guid("8b4f74d1-e5e5-47c1-98f0-cebcef1edd2f"), "16776a6d-8a98-4391-aec0-c86c8231b457", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("48875141-d808-4386-957f-7312b9fa93c2"), "579858d5-2a04-4e5c-b442-9c4f801d4675", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "Doctor", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("61e39c52-ba61-4179-9057-9054951549e7"), "fd50371d-5d54-4f6d-9457-2e813c878783", false, "test@pl.pl", true, "Wojciech", "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAECGDsIz2R5qwVvZ37UA2aKa8RDZIbXikjv88/BS67pc9zeb32uV0ZjvkQnA0WkoYww==", null, true, "341378b3-423e-4394-b2a7-d82cb04d4d1f", "TEST@PL.PL" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("61e39c52-ba61-4179-9057-9054951549e7"), new Guid("48875141-d808-4386-957f-7312b9fa93c2") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8b4f74d1-e5e5-47c1-98f0-cebcef1edd2f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c7b240fe-9f25-4b7d-9390-20b524ef0420"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ed6e56d7-046b-47d0-8f85-a2d396f97005"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("61e39c52-ba61-4179-9057-9054951549e7"), new Guid("48875141-d808-4386-957f-7312b9fa93c2") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("48875141-d808-4386-957f-7312b9fa93c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61e39c52-ba61-4179-9057-9054951549e7"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("e5397a3e-923b-47ad-9655-71162ab2ded0"), "f8841ab6-5218-4de1-8a42-ba0e2288cadf", "Admin", "ADMIN" },
                    { new Guid("fe1d423f-b2cd-4f3d-bc3b-15e6b09ef1f4"), "64d90ac3-fe7a-4a05-bce9-780145544679", "Doctor", "DOCTOR" },
                    { new Guid("854a2c1d-4ad2-4ce0-af62-8eb2c44be8a4"), "bc8daa2c-692c-4f6b-9b82-40126602d9e0", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("a5d6f294-4971-4f47-b470-ecf3410a94a1"), "b8499014-d5a7-49c0-b15c-2cd6ca40f7eb", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "Doctor", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("f5b9d3ac-3916-49cf-8d78-393fa5563374"), "401e3c26-fbfe-463d-affb-0ca8f7cf4b10", false, "test@pl.pl", true, "Wojciech", "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAELzLvItR0M1DPc1r1Pl7myL+OmwSbd2JoWe+hUfWiHcMbp9GcG5agUru52sdlyryyw==", null, true, "db1e5dd0-142f-49e6-b0d6-0e8e9f45af19", "TEST@PL.PL" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("f5b9d3ac-3916-49cf-8d78-393fa5563374"), new Guid("a5d6f294-4971-4f47-b470-ecf3410a94a1") });
        }
    }
}
