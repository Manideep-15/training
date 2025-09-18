using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Employee_Management_Tool
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

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
            Employee emp = new Employee();

            Console.WriteLine("Enter Employee Id");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter Employee Department");
            emp.Department = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Employees (Id, Name, Department, Salary) VALUES (@Id, @Name, @Dept, @Salary)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", emp.Id);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@dept", emp.Department);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Added Successfully!!");
            }

        }

        static void ViewEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Employees";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\n Employee list");
                while (reader.Read())
                {
                    employees.Add(new Employee
                        {
                           Id = Convert.ToInt32(reader["Id"]),
                           Name = reader["Name"].ToString(),
                           Department = reader["Department"].ToString(),
                           Salary = Convert.ToDouble(reader["Salary"])
                        });
                }

            }

            Console.WriteLine("\nEmployee list");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
            }
        }

        static void UpdateEmployee()
        {
             Console.WriteLine("Enter Employee Id to Update:");
             int id = Convert.ToInt32(Console.ReadLine());

             Employee emp = new Employee();
             emp.Id = id;

             Console.WriteLine("Enter New Name: ");
             emp.Name = Console.ReadLine();

             Console.WriteLine("Enter New Department: ");
             emp.Department = Console.ReadLine();

             Console.WriteLine("Enter new Salary: ");
             emp.Salary = Convert.ToDouble(Console.ReadLine());

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Update Employees SET Name=@Name, Department=@Dept, Salary=@Salary WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", emp.Id);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@dept", emp.Department);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
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
