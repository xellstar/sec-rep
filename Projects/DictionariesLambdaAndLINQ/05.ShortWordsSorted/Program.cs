using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
            string[] input = Console.ReadLine()
                            .ToLower()
                            .Split(separators);
            var result = input
                        .Where(w => w != "")
                        .OrderBy(w => w)
                        .Distinct();
            if (result <5)
            {
                Console.WriteLine(string.Join(", ", result));

            }
        }
    }
}
