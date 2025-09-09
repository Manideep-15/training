using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first value: a = " );
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your second value: b = " );
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap: a = " + a + ", b = " + b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After swap: a = " + a + " , b = " + b);
        }
    }
}
