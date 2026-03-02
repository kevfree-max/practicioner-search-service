using System;
namespace PractitionerSearchService.Models {
    /// <summary>
    /// Represents a search request from the client. Contains all the filter criteria
    /// that the user wants to apply when searching for practitioners in the database.
    /// </summary>
    public class SearchRequest {
        /// <summary>
        /// Filter by practitioner gender (e.g., "Male", "Female", "Other").
        /// If null or empty, this filter is not applied.
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Filter by practitioner city/location.
        /// If null or empty, this filter is not applied.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Filter by availability status.
        /// If null, this filter is not applied.
        /// If true, only available practitioners are returned.
        /// If false, only unavailable practitioners are returned.
        /// </summary>
        public bool? IsAvailable { get; set; }
        /// <summary>
        /// Optional: Maximum number of results to return. Defaults to 100 if not specified.
        /// </summary>
        public int? MaxResults { get; set; }
    }
}