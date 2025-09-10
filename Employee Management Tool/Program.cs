using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static List<Employee> employees = new List<Employee>();
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

            employees.Add(emp);
            Console.WriteLine("Employee added successfully");
        }

        static void ViewEmployees()
        {
            Console.WriteLine("Employee List");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
            }
        }

        static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee Id to Update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee emp = employees.Find(e => e.Id == id);
            if (emp != null)
            {
                Console.WriteLine("Enter New Name: ");
                emp.Name = Console.ReadLine();

                Console.WriteLine("Enter New Department: ");
                emp.Department = Console.ReadLine();

                Console.WriteLine("Enter new Salary: ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Employee Updated Successfully");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }

        static void DeleteEmployee()
        {
            Console.WriteLine("Enter employee Id to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee emp = employees.Find(e => e.Id == id);
            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("Employee Deleted Successfully");

            }

            else
            {
                Console.WriteLine("Employee not found");
            }
        }
    }
}
