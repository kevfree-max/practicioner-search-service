using System;
using System.Collections.Generic;

namespace PractitionerSearchService.Models {
    /// <summary>
    /// Represents the response returned from the search API.
    /// Contains the search results, metadata, and status information.
    /// </summary>
    public class SearchResponse {
        /// <summary>
        /// Indicates whether the search was successful.
        /// True = search completed without errors, False = error occurred.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// A descriptive message about the search result or any error that occurred.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The total number of practitioners found that match the search criteria.
        /// </summary>
        public int TotalResults { get; set; }

        /// <summary>
        /// The list of practitioner records that match the search criteria.
        /// </summary>
        public List<Practitioner> Results { get; set; }

        /// <summary>
        /// The timestamp when this response was generated on the server.
        /// </summary>
        public DateTime ResponseTimestamp { get; set; }

        /// <summary>
        /// Constructor for SearchResponse. Initializes the Results list to prevent null reference exceptions.
        /// </summary>
        public SearchResponse() {
            Results = new List<Practitioner>();
            ResponseTimestamp = DateTime.UtcNow;
        }
    }
}