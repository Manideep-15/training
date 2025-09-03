using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicates_from_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };
            HashSet<int> uniqueNums = new HashSet<int>(nums);

            Console.WriteLine("Unique numbers:");
            foreach (int n in uniqueNums)
            {
                Console.WriteLine(n);
            }
        }
    }
}
