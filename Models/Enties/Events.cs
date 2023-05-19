using System;
using System.Reflection.Metadata.Ecma335;

namespace SRP.Models.Enties
{
    public class Events : AuditableEntity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public int? PeopleCount { get;set; }
        public DateTime DateEventStart { get; set; }
        public DateTime? DateEventEnd { get; set; }
        public DateTime DateEventRegistrationEnd { get; set;}
        public DateTime DateEventRegistractionStart { get; set;}


    }
}
