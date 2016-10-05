using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] allNumbers = input.Split(' ');
            var counts = new SortedDictionary<double, int>();
            foreach (var numberString in allNumbers)
            {
                double number = double.Parse(numberString);
                if (counts.ContainsKey(number))
                {
                    counts[number]++;

                }
                else
                {
                    counts[number] = 1;
                }
            }
            foreach (var number in counts.Keys)
            {
                Console.WriteLine($"{number} -> {counts[number]}");
            }
        }
    }
}
