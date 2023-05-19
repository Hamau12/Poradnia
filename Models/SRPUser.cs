using Microsoft.AspNetCore.Identity;
using SRP.Models.Enties;
using System;
using System.Collections.Generic;

namespace SRP.Models
{
    public class SRPUser : IdentityUser<Guid>
    {
        public SRPUser() : base()
        {
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDoctor { get; set; } = false;
        public Doctor Doctor { get; set; }
        public ICollection<IdentityUserClaim<Guid>> Claims { get; set; }
        public ICollection<SRPUserRole> UserRoles { get; set; }
    }
}
