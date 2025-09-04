using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Error
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;

            try
            {
                int result = a / b;
                Console.WriteLine("Result is: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            }
        }
    }
}
