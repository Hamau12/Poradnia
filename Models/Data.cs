using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System;

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
            public string? PatientId { set; get; }

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
