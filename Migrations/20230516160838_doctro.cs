using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SRP.Migrations
{
    public partial class doctro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2641bfc2-29f9-46d7-bd20-064e4d4a2164"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2f709f09-bc6a-49ba-963b-e9111b2f750a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("56d3ec27-354e-4ee2-88da-f313e5717cbe"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("1e4af844-9bea-40a5-aec3-42c945e7d848"), new Guid("ee21c181-29d9-48b2-85c8-aed8c7cdbd21") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ee21c181-29d9-48b2-85c8-aed8c7cdbd21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e4af844-9bea-40a5-aec3-42c945e7d848"));

            migrationBuilder.AddColumn<bool>(
                name: "Doctor",
                table: "Users",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2f709f09-bc6a-49ba-963b-e9111b2f750a"), "f244e856-ee76-4835-8272-d86ce18cba3b", "Admin", "ADMIN" },
                    { new Guid("56d3ec27-354e-4ee2-88da-f313e5717cbe"), "d60e058b-e50b-417b-9740-9f68eb0354ce", "Doctor", "DOCTOR" },
                    { new Guid("2641bfc2-29f9-46d7-bd20-064e4d4a2164"), "63bbeafc-d342-40e1-aca6-28e20904aa21", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("ee21c181-29d9-48b2-85c8-aed8c7cdbd21"), "c12185a6-47ff-47ac-8d01-4271a268a5bd", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("1e4af844-9bea-40a5-aec3-42c945e7d848"), "e49b78de-cdfc-4bcb-95b9-be35f06cb18a", "test@pl.pl", true, "Wojciech", "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAEKK1k+9B2Dnk2TzggW/2JEGAiT4+TYfB7fM9Q9+cWRNv2vauukh7kiUR8poYLRSZAw==", null, true, "a2d4ab6d-d611-49e5-aa93-98bc7b074a1d", "TEST@PL.PL" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("1e4af844-9bea-40a5-aec3-42c945e7d848"), new Guid("ee21c181-29d9-48b2-85c8-aed8c7cdbd21") });
        }
    }
}
