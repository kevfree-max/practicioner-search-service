using System;
namespace PractitionerSearchService.Models {
    /// <summary>
    /// Represents a practitioner record in the database.
    /// This model contains all the information about a healthcare practitioner
    /// including their personal details, location, and availability status.
    /// </summary>
    public class Practitioner {
        /// <summary>
        /// Unique identifier for the practitioner. This is the primary key in the database.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the practitioner.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the practitioner.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The gender of the practitioner (e.g., "Male", "Female", "Other").
        /// Used as a search filter criterion.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// The city where the practitioner is located.
        /// Used as a search filter criterion.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// A flag indicating whether the practitioner is currently available.
        /// True = available, False = not available.
        /// Used as a search filter criterion.
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// The date when this practitioner record was created in the database.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The professional specialization or license type of the practitioner.
        /// </summary>
        public string Specialty { get; set; }

        /// <summary>
        /// Contact email address for the practitioner.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Contact phone number for the practitioner.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}