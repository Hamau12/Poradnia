using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SRP.Migrations
{
    public partial class initDoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Doctor_DoctorId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DoctorId",
                table: "Users");

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
                name: "DoctorId",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Doctor",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("eaa845cd-6cba-418e-a229-0651f664d902"), "ba588d7a-2196-4c31-8416-e301c2058358", "Admin", "ADMIN" },
                    { new Guid("1c682789-a8b8-40f8-a899-2e7f55a23d7b"), "37bc1c4e-7ecb-42ed-9ad9-996de8289401", "Doctor", "DOCTOR" },
                    { new Guid("f89f4047-4f28-4507-bb1a-2ae01ae873d5"), "039fa058-8050-4989-baf4-ecd87efa30a3", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("d080a4f3-363f-4432-9fd6-b79d75929d52"), "c9fac33d-801e-48b2-ac37-0e9b41879a25", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsDoctor", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("b1ff43e7-959e-48a1-aa87-ec2569f18470"), "47035b23-273f-4e4f-941e-38b65971f49d", "test@pl.pl", true, "Wojciech", false, "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAENLHBdiMO8yUY6hWLyCqPctUM6H2KAF3ybNxpHYCJnvZqVehCZxN5z8R9UQhJO+BLw==", null, true, "6afcc1c7-ecf3-4203-bc3c-4f204afb4cf3", "TEST@PL.PL" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("b1ff43e7-959e-48a1-aa87-ec2569f18470"), new Guid("d080a4f3-363f-4432-9fd6-b79d75929d52") });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Users_UserId",
                table: "Doctor",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Users_UserId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c682789-a8b8-40f8-a899-2e7f55a23d7b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eaa845cd-6cba-418e-a229-0651f664d902"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f89f4047-4f28-4507-bb1a-2ae01ae873d5"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("b1ff43e7-959e-48a1-aa87-ec2569f18470"), new Guid("d080a4f3-363f-4432-9fd6-b79d75929d52") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d080a4f3-363f-4432-9fd6-b79d75929d52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1ff43e7-959e-48a1-aa87-ec2569f18470"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Doctor");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Users",
                type: "uniqueidentifier",
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

            migrationBuilder.CreateIndex(
                name: "IX_Users_DoctorId",
                table: "Users",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Doctor_DoctorId",
                table: "Users",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
