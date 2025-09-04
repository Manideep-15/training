using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting_eligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

          
            if (age > 18)
                Console.WriteLine("You can vote.");
            else
                Console.WriteLine("You cannot vote.");
        }
    }
}
