using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_words_in_sentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "C# is fun to learn";
            string[] parts = sentence.Split(' ');

            for (int i = parts.Length - 1; i >= 0; i--)
            {
                Console.Write(parts[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
