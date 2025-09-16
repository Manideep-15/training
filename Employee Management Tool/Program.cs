using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Employee_Management_Tool
{
    class Program
    {
        static string connectionString = "Server = MANDEEP_OFFICE\\SQLEXPRESS; Database = EmployeeDB; Trusted_Connection = True;";
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("Employee Management Tool");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Update Employees");
                Console.WriteLine("4. Delete Employees");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ViewEmployees();
                        break;
                    case 3:
                        UpdateEmployee();
                        break;
                    case 4:
                        DeleteEmployee();
                        break;
                    case 5:
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid choice..");
                        break;
                }
            }
        }

        static void AddEmployee()
        {
            Console.WriteLine("Enter Employee Id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Department");
            string dept = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            double salary = Convert.ToDouble(Console.ReadLine());

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Employees (Id, Name, Department, Salary) VALUES (@Id, @Name, @Dept, @Salary)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@dept", dept);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Added Successfully!!");
            }

        }

        static void ViewEmployees()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Employees";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\n Employee list");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Dept: {reader["Department"]}, Salary: {reader["Salary"]}");

                }

            }
        }

        static void UpdateEmployee()
        {
             Console.WriteLine("Enter Employee Id to Update:");
             int id = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter New Name: ");
             string Name = Console.ReadLine();

             Console.WriteLine("Enter New Department: ");
             string dept = Console.ReadLine();

             Console.WriteLine("Enter new Salary: ");
             double salary = Convert.ToDouble(Console.ReadLine());

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Update Employees SET Name=@Name, Department=@Dept, Salary=@Salary WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@dept", dept);
                cmd.Parameters.AddWithValue("@Salary", salary);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Employee Updated Successfully");
                else
                    Console.WriteLine("Employees not found");

            }

        }

        static void DeleteEmployee()
        {
            Console.WriteLine("Enter employee Id to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Employees WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Employee Deleted Successfully");
                else
                {
                    Console.WriteLine("Employee not found");
                }
            }
        }
    }
}
