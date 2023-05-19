using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SRP.Migrations
{
    public partial class doctro5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3453a279-7609-4c9d-83cf-e95f52b63309"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a44d56ec-6454-4e8e-9516-1bd7d26a6f59"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fc3757b9-b29d-4ec2-bab4-5a9929919096"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("34fa4ace-95a2-478a-b275-33d7f6d71f8e"), new Guid("47fe8461-1e4e-4f1f-830a-782b52120f7f") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("47fe8461-1e4e-4f1f-830a-782b52120f7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34fa4ace-95a2-478a-b275-33d7f6d71f8e"));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Doctor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Doctor",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("e552675e-9d15-4488-b8be-9947397c4ac8"), "053c03da-1504-4e31-8169-47df80a709bc", "Admin", "ADMIN" },
                    { new Guid("749b251f-8bc4-4ff0-a384-503788d9307b"), "ceb89a0c-9372-47d2-acb9-de6a4c2854af", "Doctor", "DOCTOR" },
                    { new Guid("554d8a20-a18a-4385-b22d-3a64ed983d1f"), "885698f4-4de0-4d54-b958-81ef4d7d85f9", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("45ac1255-b37d-441e-8578-30e853d54646"), "2f57b7de-128d-462c-a438-9c6e185e1397", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "DoctorId", "Email", "EmailConfirmed", "FirstName", "IsDoctor", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("82c9ba0e-25c3-41a5-b2d1-fad05b4f6f4c"), "b1161601-ac8a-4e08-9fed-6e4e88014cbb", null, "test@pl.pl", true, "Wojciech", false, "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAEPXiT+6d86s5qGmhiTJts8H3M0VMMoGbKkI/mQhB6guJjNluA7jmSnV4Z/Ho7JWGjw==", null, true, "0a1156ac-2b75-4ea7-80d0-526489c0d4fe", "TEST@PL.PL" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("82c9ba0e-25c3-41a5-b2d1-fad05b4f6f4c"), new Guid("45ac1255-b37d-441e-8578-30e853d54646") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("554d8a20-a18a-4385-b22d-3a64ed983d1f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("749b251f-8bc4-4ff0-a384-503788d9307b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e552675e-9d15-4488-b8be-9947397c4ac8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("82c9ba0e-25c3-41a5-b2d1-fad05b4f6f4c"), new Guid("45ac1255-b37d-441e-8578-30e853d54646") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("45ac1255-b37d-441e-8578-30e853d54646"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82c9ba0e-25c3-41a5-b2d1-fad05b4f6f4c"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Doctor");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a44d56ec-6454-4e8e-9516-1bd7d26a6f59"), "434b7c4b-4497-4730-a981-e84ea4843dce", "Admin", "ADMIN" },
                    { new Guid("3453a279-7609-4c9d-83cf-e95f52b63309"), "565754f5-940e-4dd7-953e-da111b5c3157", "Doctor", "DOCTOR" },
                    { new Guid("fc3757b9-b29d-4ec2-bab4-5a9929919096"), "29604360-a11f-4b29-9dc1-36e2e5bbd7f3", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("47fe8461-1e4e-4f1f-830a-782b52120f7f"), "f8d3e81e-f035-45e1-88ae-c14aa1f76724", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "DoctorId", "Email", "EmailConfirmed", "FirstName", "IsDoctor", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("34fa4ace-95a2-478a-b275-33d7f6d71f8e"), "291f61d2-b08d-479c-bce3-b64fb224b145", null, "test@pl.pl", true, "Wojciech", false, "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAEMFAd1cUc+QYUzlFxm1TDy+QL0V3FyPZo8vAhVN3oREb6yIXDkbvDQnt2jP5dKzWJA==", null, true, "cc5d6dc3-563c-4f05-9bd6-233e5b9a435d", "TEST@PL.PL" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("34fa4ace-95a2-478a-b275-33d7f6d71f8e"), new Guid("47fe8461-1e4e-4f1f-830a-782b52120f7f") });
        }
    }
}
