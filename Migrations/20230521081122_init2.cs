using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poradnia.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("04c6ca88-691a-491e-ba33-b697113d8ce7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("709aa7ef-8c95-4b01-b8d5-ff5c7e856d6d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d5ab315e-ca58-4971-a901-e109146974b5"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("4992b705-1e36-4af6-a9bf-63abcb35e7b1"), new Guid("c58e18ee-6905-4060-8826-4307c1128098") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c58e18ee-6905-4060-8826-4307c1128098"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4992b705-1e36-4af6-a9bf-63abcb35e7b1"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("e7bf2cca-008b-4836-ad4e-f1e7bc80f34f"), "41c62748-37df-4357-b64d-cc9845c1283b", "Admin", "ADMIN" },
                    { new Guid("563eff7a-1b61-46b3-ab04-b426a3dd023d"), "b40b577a-3e82-491e-a44c-d231bced0b3d", "Specialist", "SPECIALIST" },
                    { new Guid("a01c328e-7bbf-4fb9-8c35-bc46570a9dde"), "449b3ffb-c314-4631-9e55-0e9de452d253", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("8501533f-4c18-4719-b685-2abbb1f3135f"), "9c75188c-3502-4892-b2b4-3095f183a11e", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsDoctor", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("2184fade-1a65-404f-8e6d-ba96e7d79300"), "80a27f74-af43-4851-b4d5-115c0ba650db", "test@pl.pl", true, "Wojciech", false, "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAENH2SilJRXNkeYyUwZm8gB8WrUvXb56HeVYeBvghEoh7pjJmzgujpiA/MQ6iDiIoCg==", null, true, "c35bbe3d-e089-471a-bd85-90e71fa2bdc3", "TEST@PL.PL" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("2184fade-1a65-404f-8e6d-ba96e7d79300"), new Guid("8501533f-4c18-4719-b685-2abbb1f3135f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("563eff7a-1b61-46b3-ab04-b426a3dd023d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a01c328e-7bbf-4fb9-8c35-bc46570a9dde"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e7bf2cca-008b-4836-ad4e-f1e7bc80f34f"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("2184fade-1a65-404f-8e6d-ba96e7d79300"), new Guid("8501533f-4c18-4719-b685-2abbb1f3135f") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8501533f-4c18-4719-b685-2abbb1f3135f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2184fade-1a65-404f-8e6d-ba96e7d79300"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("709aa7ef-8c95-4b01-b8d5-ff5c7e856d6d"), "2affadb3-7cd5-462f-bd95-8c6880021984", "Admin", "ADMIN" },
                    { new Guid("04c6ca88-691a-491e-ba33-b697113d8ce7"), "7dd42aac-132f-4f33-8949-035694f5df3e", "Specialist", "DOCTOR" },
                    { new Guid("d5ab315e-ca58-4971-a901-e109146974b5"), "215bbd03-041c-4432-96eb-5654e5bebaa2", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("c58e18ee-6905-4060-8826-4307c1128098"), "ab8f951e-d54c-4c51-8c27-d0e6ee173837", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsDoctor", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("4992b705-1e36-4af6-a9bf-63abcb35e7b1"), "49bdd729-6bc0-41c5-a531-f999c211b977", "test@pl.pl", true, "Wojciech", false, "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAEIT7Z+O8yPQszBqmT4xmjY0jKJsfYDn7t4i+pPeozu8NvrtTAhYXDMIPkPY51ViviA==", null, true, "8583100b-86c1-45c4-8485-fc676afaa46e", "TEST@PL.PL" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("4992b705-1e36-4af6-a9bf-63abcb35e7b1"), new Guid("c58e18ee-6905-4060-8826-4307c1128098") });
        }
    }
}
