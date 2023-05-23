using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SRP.Models.Enties;
using System;

namespace SRP.Models.Seed
{
    public static class SeedDefaultUsers
    {
        public static void Seed(this ModelBuilder builder)
        {
            var adminUser = new SRPUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "Wojciech",
                LastName = "Nytko",
                Email = "test@pl.pl",
                NormalizedEmail = "TEST@PL.PL",
                UserName = "TEST@PL.PL",
                NormalizedUserName = "TEST@PL.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            adminUser.PasswordHash = new PasswordHasher<SRPUser>().HashPassword(adminUser, "1qaz@WSX");
            var doctorUser = new SRPUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "Jan",
                LastName = "Doktor",
                Email = "test2@pl.pl",
                NormalizedEmail = "TEST2@PL.PL",
                UserName = "TEST2@PL.PL",
                NormalizedUserName = "TEST2@PL.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                IsDoctor= true
            };
            doctorUser.PasswordHash = new PasswordHasher<SRPUser>().HashPassword(adminUser, "1qaz@WSX");
            var adminRole = new SRPRole()
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            };
            var DoctorRole = new SRPRole()
            {
                Id = Guid.NewGuid(),
                Name = "Specialist",
                NormalizedName = "SPECIALIST"
            };

            var unfonfirmedRole = new SRPRole()
            {
                Id = Guid.NewGuid(),
                Name = "Unconfirmed",
                NormalizedName = "UNCONFIRMED"
            };

            var superAdminRole = new SRPRole()
            {
                Id = Guid.NewGuid(),
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN"
            };

            var adminUserRole = new SRPUserRole()
            {
                RoleId = superAdminRole.Id,
                UserId = adminUser.Id
            };
            var doctorUserRole = new SRPUserRole()
            {
                RoleId = DoctorRole.Id,
                UserId = doctorUser.Id
            };
            var publishDocotr = new Specialist()
            {
                Id = Guid.NewGuid(),
                ImageName = "fj1ifyrjhou.jpg",
                UserId = doctorUser.Id,
                FirstName= doctorUser.FirstName,
                LastName= doctorUser.LastName,
                Description = "Lekarz testowy",
                Specialisation = Enums.Specialisation.PsychologiaOgólna
            };
            builder.Entity<SRPUser>().HasData(adminUser);
            builder.Entity<SRPUser>().HasData(doctorUser);
            builder.Entity<SRPRole>().HasData(adminRole);
            builder.Entity<SRPRole>().HasData(DoctorRole);
            builder.Entity<SRPRole>().HasData(unfonfirmedRole);
            builder.Entity<SRPRole>().HasData(superAdminRole);
            builder.Entity<SRPUserRole>().HasData(adminUserRole);
            builder.Entity<SRPUserRole>().HasData(doctorUserRole);
            builder.Entity<Specialist>().HasData(publishDocotr);
        }
    }
}
