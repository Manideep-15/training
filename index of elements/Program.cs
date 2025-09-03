using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index_of_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "apple", "banana", "mango", "grapes" };

            Console.WriteLine("Enter fruit name to search:");
            string name = Console.ReadLine();

            int index = fruits.IndexOf(name);

            if (index != -1)
            {
                Console.WriteLine(name + " found at index " + index);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
