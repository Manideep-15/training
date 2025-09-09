using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_without_temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your value: a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your value: b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap: a = " + a + " , b = " + b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After swap: a = " + a + " , b =5" +
                "5 " + b);

        }
    }
}
