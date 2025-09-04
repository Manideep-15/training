using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition_method
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main()
        {
            Console.Write("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum is: " + Add(x, y));
        }
    }
}
