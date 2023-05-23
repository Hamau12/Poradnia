using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poradnia.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: new Guid("8d4aa675-5ea6-46ca-a2b8-c64211097354"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0dbf53f2-bfda-4b41-99a8-fb853a5791d7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("214e9d76-c596-4913-a0c4-4001461f6ec9"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("92220808-2e55-4b79-b00e-f18e985e5f33"), new Guid("58f3cda0-62d4-4925-8170-c935054e6889") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("e8a59fe2-cb12-4dae-9bae-5ddde4b77a8b"), new Guid("b22407a4-5a81-4743-8212-3987e29d4909") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("58f3cda0-62d4-4925-8170-c935054e6889"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b22407a4-5a81-4743-8212-3987e29d4909"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92220808-2e55-4b79-b00e-f18e985e5f33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8a59fe2-cb12-4dae-9bae-5ddde4b77a8b"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2ac783eb-a6e7-48d4-b722-eb496c9d9958"), "a4ec28ad-23c4-4fd9-84f7-6b885b69e391", "Admin", "ADMIN" },
                    { new Guid("01e95f47-754a-4c6b-8874-db00ce0679ec"), "6ae45ef8-2a65-4644-a6cd-bbfb938ead76", "Specialist", "SPECIALIST" },
                    { new Guid("78f84a3e-974a-4b55-8a81-369def897bc8"), "bae5fbc2-6513-4686-824d-fcc25c959599", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("8e4a6b0a-faed-4f3f-8085-bf69abd1cd6a"), "4c007ef4-8045-4796-94cb-e87148d9c401", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsDoctor", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { new Guid("b0d7a395-eb34-457c-a661-765a2017f6c2"), "1af05829-0913-4c2b-a272-115f2fa1a2c2", "test@pl.pl", true, "Wojciech", false, "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAEE5HmjcJRiaQRI2yIvt5F4X9rE6QAfQ/Yx6FNtNyiWKdeJA7VYduCqgqJDVLVCRT7g==", null, true, "d84c54ae-957f-439e-adfd-9c181b3b8853", "TEST@PL.PL" },
                    { new Guid("a4b0be1b-67cc-4db3-8e39-3412a4852f6e"), "7c1caaf3-32ca-4d8b-9ca6-be6f404ec035", "test2@pl.pl", true, "Jan", true, "Doktor", false, null, "TEST2@PL.PL", "TEST2@PL.PL", "AQAAAAEAACcQAAAAEKLxRA17IpGoznU9BSvB7PpvFo/YFWoEcE6B7W2BN9RmgtmLzE748OhAoZnecfqMCQ==", null, true, "5fa92ec5-bda3-42f7-a609-1ea69f73ec81", "TEST2@PL.PL" }
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "AppointmentId", "Created", "CreatedBy", "Description", "FirstName", "ImageName", "LastName", "Specialisation", "UserId" },
                values: new object[] { new Guid("de08257e-8ffd-4c10-8312-8b77a3d21164"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Lekarz testowy", "Jan", "fj1ifyrjhou.jpg", "Doktor", 0, new Guid("a4b0be1b-67cc-4db3-8e39-3412a4852f6e") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("b0d7a395-eb34-457c-a661-765a2017f6c2"), new Guid("8e4a6b0a-faed-4f3f-8085-bf69abd1cd6a") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a4b0be1b-67cc-4db3-8e39-3412a4852f6e"), new Guid("01e95f47-754a-4c6b-8874-db00ce0679ec") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: new Guid("de08257e-8ffd-4c10-8312-8b77a3d21164"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2ac783eb-a6e7-48d4-b722-eb496c9d9958"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("78f84a3e-974a-4b55-8a81-369def897bc8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a4b0be1b-67cc-4db3-8e39-3412a4852f6e"), new Guid("01e95f47-754a-4c6b-8874-db00ce0679ec") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("b0d7a395-eb34-457c-a661-765a2017f6c2"), new Guid("8e4a6b0a-faed-4f3f-8085-bf69abd1cd6a") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("01e95f47-754a-4c6b-8874-db00ce0679ec"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e4a6b0a-faed-4f3f-8085-bf69abd1cd6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4b0be1b-67cc-4db3-8e39-3412a4852f6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0d7a395-eb34-457c-a661-765a2017f6c2"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0dbf53f2-bfda-4b41-99a8-fb853a5791d7"), "7575eb8c-bca3-4da4-b8d0-188119858873", "Admin", "ADMIN" },
                    { new Guid("58f3cda0-62d4-4925-8170-c935054e6889"), "2879f6ba-f954-4c6a-9727-d36d72246768", "Specialist", "SPECIALIST" },
                    { new Guid("214e9d76-c596-4913-a0c4-4001461f6ec9"), "798de1de-e8e5-4695-86e3-bc1c536fcc30", "Unconfirmed", "UNCONFIRMED" },
                    { new Guid("b22407a4-5a81-4743-8212-3987e29d4909"), "0ab0a7a0-0e7b-42ea-8ad2-a6cff37378f2", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsDoctor", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { new Guid("e8a59fe2-cb12-4dae-9bae-5ddde4b77a8b"), "2e34dfd1-8a7e-426f-8f8c-b5cc71d7e81a", "test@pl.pl", true, "Wojciech", false, "Nytko", false, null, "TEST@PL.PL", "TEST@PL.PL", "AQAAAAEAACcQAAAAEHwGPBPjF9ArROm+OA/Yb37kFsDeqySxi20gfatDNALVZYH+I30yFAXMgUwgyEO1wg==", null, true, "854d811f-b797-401b-bccd-519ee0cbd987", "TEST@PL.PL" },
                    { new Guid("92220808-2e55-4b79-b00e-f18e985e5f33"), "0e76357b-c319-4a71-a2f7-2c0bdaea6c11", "test2@pl.pl", true, "Jan", true, "Doktor", false, null, "TEST2@PL.PL", "TEST2@PL.PL", "AQAAAAEAACcQAAAAEEC3bLRnkD2X1yRxDQKgPxR7vwkpubd2aD9k42UHMnohfx5n3P0QPvtdJh5LgDlIIg==", null, true, "8c5e9846-50ca-4ba8-8a0a-0c81443fc598", "TEST2@PL.PL" }
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "AppointmentId", "Created", "CreatedBy", "Description", "FirstName", "ImageName", "LastName", "Specialisation", "UserId" },
                values: new object[] { new Guid("8d4aa675-5ea6-46ca-a2b8-c64211097354"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Lekarz testowy", "Jan", "lstcxbigoiv.png", "Doktor", 0, new Guid("92220808-2e55-4b79-b00e-f18e985e5f33") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("e8a59fe2-cb12-4dae-9bae-5ddde4b77a8b"), new Guid("b22407a4-5a81-4743-8212-3987e29d4909") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("92220808-2e55-4b79-b00e-f18e985e5f33"), new Guid("58f3cda0-62d4-4925-8170-c935054e6889") });
        }
    }
}
