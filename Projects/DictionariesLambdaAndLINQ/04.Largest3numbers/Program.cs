using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var numbers = Console.ReadLine().Split().Select(var => int.Parse(var)).ToArray();
            string[] strings = Console.ReadLine().Split(' ');
            List<int> nums = strings
                                    .Select(int.Parse)
                                    .ToList();
            var sortedNums = nums.OrderByDescending(x => x);
            var largest3Nums = sortedNums.Take(3);
            Console.WriteLine(string.Join(" ", largest3Nums));

        }
    }
}
