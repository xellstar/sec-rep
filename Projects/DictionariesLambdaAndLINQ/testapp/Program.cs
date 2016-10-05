using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] myInts = input.Select(int.Parse).ToArray();
            myInts = myInts
                .Where(num => num % 2 == 0)
                .ToArray();
            Console.WriteLine();
        }
    }
}
