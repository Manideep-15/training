using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            int count = 0;

            for (int i = 0;i < word.Length; i++)
            {
                char ch = Char.ToLower(word[i]);
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count = count + 1;
                }
            }

            Console.WriteLine("Vowels are: " + count);
        }
         
    }
}

