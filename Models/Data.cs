using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System;
using SRP.Models.Enties;
using SRP.Models.Enums;

namespace Poradnia.Models
{
    public class Data
    {
        public class AppointmentSlot
        {
            public Guid Id { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }

            public string? PatientName { set; get; }

            public string? Text => PatientName;

            [JsonPropertyName("patient")]
            public Guid? PatientId { set; get; }
            public Guid SpecialistId { get; set; }

            public string Status { get; set; } = "free";

        }

        public class DoctorDbContext : DbContext
        {
            public DbSet<AppointmentSlot> Appointments { get; set; }

            public DoctorDbContext(DbContextOptions<DoctorDbContext> options) : base(options) { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            }
        }
    }
}
