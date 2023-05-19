using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SRP.Migrations
{
    public partial class doctro4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDoctor",
                table: "Users",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDoctor",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "Doctor",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
    }
}
