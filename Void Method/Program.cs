using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    internal class Program
    {
        static void GreetUser(string name)
        {
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Welcome " + name); 
        }

        static void Main()
        {
            string user = "Neha";
            GreetUser(user);
        }
    }
}
