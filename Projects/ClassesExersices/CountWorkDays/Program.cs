using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumberSums
{
    class LastKNumberSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            numbers[0] = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = numbers.Length - 1; i >= (n - k); i--)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
