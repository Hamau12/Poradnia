using SRP.Models.Enums;
using System;
using System.Collections.Generic;
using Poradnia.Models;

namespace SRP.Models.Enties
{
    public class Specialist : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get;set;}
        public Specialisation Specialisation { get;set;}
        public string ImageName { get; set; }
        public SRPUser User { get; set; }
        public Data.AppointmentSlot AppointmentSlot { get; set; }
        public Guid AppointmentId { get; set; }

    }
}
