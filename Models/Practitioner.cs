using System;

namespace PractitionerSearchService.Models
{
    public class Practitioner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public bool Availability { get; set; }
    }
}