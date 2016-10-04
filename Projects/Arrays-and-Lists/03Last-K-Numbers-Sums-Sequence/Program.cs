using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            string[] tokens = inputNumbers.Split(',');
            List<int> numbers = new List<int>();
            int oneNumber;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out oneNumber))
                {
                    numbers.Add(oneNumber);
                }
            }
            Console.WriteLine(numbers);
        }
    }
}
