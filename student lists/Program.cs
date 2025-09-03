using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();

            students.Add("Rahul");
            students.Add("Sneha");
            students.Add("Amit");
            students.Add("Priya");

            Console.WriteLine("Students are:");
            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}
