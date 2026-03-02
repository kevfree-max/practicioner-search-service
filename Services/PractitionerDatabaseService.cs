using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PractitionerSearchService.Services
{
    public class PractitionerDatabaseService
    {
        private readonly string _connectionString;

        public PractitionerDatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Practitioner>> SearchPractitionersAsync(string searchTerm)
        {
            var practitioners = new List<Practitioner>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var command = new SqlCommand("SELECT * FROM Practitioners WHERE Name LIKE @searchTerm", connection);
                command.Parameters.AddWithValue("@searchTerm", '%' + searchTerm + '%');

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        // Assuming Practitioner class has properties: Id, Name, Specialty
                        practitioners.Add(new Practitioner
                        {
                            Id = reader.GetInt32(0), // Adjust index as per your table structure
                            Name = reader.GetString(1), // Adjust index as per your table structure
                            Specialty = reader.GetString(2) // Adjust index as per your table structure
                        });
                    }
                }
            }

            return practitioners;
        }
    }

    public class Practitioner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
    }
}