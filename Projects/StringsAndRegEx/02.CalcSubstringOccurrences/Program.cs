using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CalcSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string occur = Console.ReadLine().ToLower();
            int counter = 0;
            int index = input.IndexOf(occur);
            while (index != -1)
            {
                counter++;
                index = input.IndexOf(occur, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
