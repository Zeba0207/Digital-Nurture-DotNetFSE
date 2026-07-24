using System;
using Microsoft.Data.SqlClient;

namespace Exercise30_ADONET_CRUD
{
    internal class Program
    {
        static string connectionString =
            @"Server=.\SQLEXPRESS;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            Console.WriteLine("===== ADO.NET CRUD OPERATIONS =====\n");

            // Insert
            InsertEmployee("Zeba", "IT", 50000);

            Console.WriteLine("\nEmployee List:");
            DisplayEmployees();

            // Update
            UpdateEmployee(1, 55000);

            Console.WriteLine("\nAfter Update:");
            DisplayEmployees();

            // Delete
            DeleteEmployee(1);

            Console.WriteLine("\nAfter Delete:");
            DisplayEmployees();

            Console.WriteLine("\nProgram Completed Successfully.");
            Console.ReadKey();
        }

        static void InsertEmployee(string name, string department, decimal salary)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Employees(Name, Department, Salary)
                                 VALUES(@Name, @Department, @Salary)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@Salary", salary);

                connection.Open();

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Employee Inserted Successfully.");
            }
        }

        static void DisplayEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No records found.");
                    return;
                }

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"ID: {reader["Id"]} | Name: {reader["Name"]} | Department: {reader["Department"]} | Salary: {reader["Salary"]}");
                }

                reader.Close();
            }
        }

        static void UpdateEmployee(int id, decimal salary)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    "UPDATE Employees SET Salary=@Salary WHERE Id=@Id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Salary", salary);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Employee Updated Successfully.");
                else
                    Console.WriteLine("Employee Not Found.");
            }
        }

        static void DeleteEmployee(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    "DELETE FROM Employees WHERE Id=@Id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Employee Deleted Successfully.");
                else
                    Console.WriteLine("Employee Not Found.");
            }
        }
    }
}