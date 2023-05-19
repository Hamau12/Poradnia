using SRP.Models.Enums;
using System;
using System.Collections.Generic;

namespace SRP.Models.Enties
{
    public class Doctor : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get;set;}
        public Specialisation Specialisation { get;set;}
        public string ImageName { get; set; }
        public ICollection<SRPUser> UserRoles { get; set; }

    }
}
