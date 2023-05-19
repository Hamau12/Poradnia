using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SRP.Migrations
{
    public partial class doctro3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Doctor");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5bd561fe-b979-4b46-a7be-02b867a2a525"), "722d1b39-3df6-4196-80cd-aa8cad38777d", "Admin", "ADMIN" },
                    { new Guid("b00acae9-c418-46aa-aea7-fc7e374f8e93"), "4ef8cfee-4544-473a-a293-57054c3a6f40", "Doctor", "DOCTOR" },
                    { new Guid("edf9f8c8-cdda-47f3-aa53-1864e81f5d39"), "a6e5efc9-0216-4ce8-a78b-ef05d2a49a68", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("7616a265-16d6-46ef-9457-aa7516096923"), "11c55e98-9af5-4ccc-bf09-d33f3f96fc19", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "Doctor", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("c4f43f7b-1c91-4d07-ac2d-2db3529c7760"), "1000620f-96d3-43e0-86b0-e16f5b0b35ea", false, "test@pl.pl", true, "Wojciech", "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAEOmSmge6ewgOdMdjg+7XjaMWJ6quGmcx44YtL1LfVz1L9TWfu0K1+mI6k+c5d/0w5g==", null, true, "2b5ecbd0-c486-49db-95d5-5f3c67a8004a", "TEST@PL.PL" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("c4f43f7b-1c91-4d07-ac2d-2db3529c7760"), new Guid("7616a265-16d6-46ef-9457-aa7516096923") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5bd561fe-b979-4b46-a7be-02b867a2a525"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b00acae9-c418-46aa-aea7-fc7e374f8e93"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("edf9f8c8-cdda-47f3-aa53-1864e81f5d39"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c4f43f7b-1c91-4d07-ac2d-2db3529c7760"), new Guid("7616a265-16d6-46ef-9457-aa7516096923") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7616a265-16d6-46ef-9457-aa7516096923"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f43f7b-1c91-4d07-ac2d-2db3529c7760"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
