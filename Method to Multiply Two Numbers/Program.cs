using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_to_Multiply_Two_Numbers
{
    internal class Program
    {
        static int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }

        static void Main()
        {
            int x = 4;
            int y = 5;
            int res = Multiply(x, y);
            Console.WriteLine("Multiplication is: " + res);
        }
    }
}
