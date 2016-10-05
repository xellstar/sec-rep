using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] allWords = input.Split();
            var count = new Dictionary<string, int>();
            foreach (var word in allWords)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;

                }
                else
                {
                    count[word] = 1;
                }
            }
            var results = new List<string>();
            foreach (var pair in count)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine(string.Join(" ", results));
                }
            }
        }
    }
}
