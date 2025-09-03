using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "madam";
            string reversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            if (reversed == text)
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
        }
    }
}
