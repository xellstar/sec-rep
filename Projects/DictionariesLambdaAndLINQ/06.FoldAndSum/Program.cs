using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] leftRow = array.Take(k).Reverse().ToArray();
            int[] rightRow = array.Reverse().Take(k).ToArray();
            int[] rowOne = leftRow.Concat(rightRow).ToArray();
            int[] rowTwo = array.Skip(k).Take(k * 2).ToArray();
            var arraySum = rowOne.Select((x, index) => x + rowTwo[index]);
            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}
