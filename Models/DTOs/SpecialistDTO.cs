using SRP.Models.Enums;
using System;

namespace SRP.Models.DTOs
{
    public class SpecialistDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public Specialisation Specialisation { get; set; }
        public string ImageName { get; set; }
    }
}
