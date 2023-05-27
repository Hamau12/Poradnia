﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SRP.Models;

namespace Poradnia.Migrations
{
    [DbContext(typeof(SrpDbContext))]
    partial class SrpDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Poradnia.Models.Data+AppointmentSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SpecialistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SpecialistId")
                        .IsUnique();

                    b.ToTable("tmentSlot");
                });

            modelBuilder.Entity("SRP.Models.Enties.Access", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Alert")
                        .HasColumnType("bit");

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserInternalId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Access");
                });

            modelBuilder.Entity("SRP.Models.Enties.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReportId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("SRP.Models.Enties.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("SRP.Models.Enties.Specialist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Specialisation")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f9f9761-55a1-4404-89c8-8ac86ba18350"),
                            AppointmentId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Description = "Lekarz testowy",
                            FirstName = "Jan",
                            ImageName = "fj1ifyrjhou.jpg",
                            LastName = "Doktor",
                            Specialisation = 0,
                            UserId = new Guid("cc4d9a8e-3b50-4adf-a6b5-1de863ed76da")
                        });
                });

            modelBuilder.Entity("SRP.Models.SRPRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7e14a5bc-508f-48b2-8866-911314262b20"),
                            ConcurrencyStamp = "8b2305a0-42e6-4659-82d5-05e690bff4d2",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("705008d4-b1f9-44b4-8bd7-a52d498b298d"),
                            ConcurrencyStamp = "5f89845f-1760-4582-acbf-45645e6f5b6e",
                            Name = "Specialist",
                            NormalizedName = "SPECIALIST"
                        },
                        new
                        {
                            Id = new Guid("50ea507f-e2c4-4518-8f10-044907c56629"),
                            ConcurrencyStamp = "e5463516-dc4a-46c5-9cb0-e2b81436dbe6",
                            Name = "Unconfirmed",
                            NormalizedName = "UNCONFIRMED"
                        },
                        new
                        {
                            Id = new Guid("ec195a41-9305-4df2-a78f-dc1e502c6669"),
                            ConcurrencyStamp = "39af8344-bd8d-47fc-af79-919d920b4c04",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        });
                });

            modelBuilder.Entity("SRP.Models.SRPUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDoctor")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dd994157-877b-4c03-8b47-8de88047b37f"),
                            ConcurrencyStamp = "d725e46b-c054-4787-b804-7668d73db48b",
                            Email = "test@pl.pl",
                            EmailConfirmed = true,
                            FirstName = "Wojciech",
                            IsDoctor = false,
                            LastName = "Nytko",
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@PL.PL",
                            NormalizedUserName = "TEST@PL.PL",
                            PasswordHash = "AQAAAAEAACcQAAAAEE4gn2503Wm5ODM7/EzQk89gzpvP9r4pFKkDjTA1qxa6cZmmrsPTat+MLjD55QrJpA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "b7177dea-910d-43f6-a85a-90d3f6f5fb5d",
                            UserName = "TEST@PL.PL"
                        },
                        new
                        {
                            Id = new Guid("cc4d9a8e-3b50-4adf-a6b5-1de863ed76da"),
                            ConcurrencyStamp = "a297a8ed-baa4-4030-9b4a-9de080147c8a",
                            Email = "test2@pl.pl",
                            EmailConfirmed = true,
                            FirstName = "Jan",
                            IsDoctor = true,
                            LastName = "Doktor",
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST2@PL.PL",
                            NormalizedUserName = "TEST2@PL.PL",
                            PasswordHash = "AQAAAAEAACcQAAAAEMStkYjOwGKDdr2NzKwu/XK5MbhWe+C5pEbH0uFqMUtQBVe+BEmPUgq/oQf4pFx+Tw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "8980509f-3a3c-43d3-953d-df50259807aa",
                            UserName = "TEST2@PL.PL"
                        });
                });

            modelBuilder.Entity("SRP.Models.SRPUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("dd994157-877b-4c03-8b47-8de88047b37f"),
                            RoleId = new Guid("ec195a41-9305-4df2-a78f-dc1e502c6669")
                        },
                        new
                        {
                            UserId = new Guid("cc4d9a8e-3b50-4adf-a6b5-1de863ed76da"),
                            RoleId = new Guid("705008d4-b1f9-44b4-8bd7-a52d498b298d")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("SRP.Models.SRPRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("SRP.Models.SRPUser", null)
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("SRP.Models.SRPUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("SRP.Models.SRPUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Poradnia.Models.Data+AppointmentSlot", b =>
                {
                    b.HasOne("SRP.Models.Enties.Specialist", null)
                        .WithOne("AppointmentSlot")
                        .HasForeignKey("Poradnia.Models.Data+AppointmentSlot", "SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SRP.Models.Enties.Comment", b =>
                {
                    b.HasOne("SRP.Models.Enties.Report", "Report")
                        .WithMany("Comments")
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SRP.Models.Enties.Specialist", b =>
                {
                    b.HasOne("SRP.Models.SRPUser", "User")
                        .WithMany("Doctor")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SRP.Models.SRPUserRole", b =>
                {
                    b.HasOne("SRP.Models.SRPRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SRP.Models.SRPUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
