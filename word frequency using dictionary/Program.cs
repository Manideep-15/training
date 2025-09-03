using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_frequency_using_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "hello world hello code";
            string[] words = sentence.Split(' ');

            Dictionary<string, int> freq = new Dictionary<string, int>();

            foreach (string w in words)
            {
                if (freq.ContainsKey(w))
                {
                    freq[w]++;
                }
                else
                {
                    freq[w] = 1;
                }
            }

            foreach (var item in freq)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
        }
    }
}
