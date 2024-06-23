using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Connection string
        string connectionString = "Server=yourServer;Database=yourDatabase;User Id=userId;Password=password;";

        // SQL query
        string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

        // Create a SQL connection
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Open the connection
            connection.Open();

            // Create a SQL command
            SqlCommand command = new SqlCommand(query, connection);

            // Execute the query and get a reader
            SqlDataReader reader = command.ExecuteReader();

            // Read and print the table names
            while (reader.Read())
            {
                string tableName = reader.GetString(0);
                Console.WriteLine($"Table Name: {tableName}");
            }

            // Close the reader
            reader.Close();
        }
    }
}