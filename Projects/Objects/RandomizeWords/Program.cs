using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] randomizedWords = randomve(input);
            foreach (var item in randomizedWords)
            {
               Console.WriteLine(item);
            }

        }

        static string[] randomve(string input)
        {
            Random rnd = new Random();
            string[] words = input.Split(' ');

            for (int pos1 = 0; pos1 <= words.Length - 1; pos1++)
            {

                int rndPos = rnd.Next(words.Length);

         string oldValue      = words[pos1];
                words[pos1]   = words[rndPos];
                words[rndPos] = oldValue;
            }

            return words;
        }
    }
}
