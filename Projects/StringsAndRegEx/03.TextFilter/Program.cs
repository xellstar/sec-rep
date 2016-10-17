using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ' ' };
            string[] bannedWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries );
            string input = Console.ReadLine();
            foreach (var bannedWord in bannedWords)
            {
                if (input.Contains(bannedWord))
                {
                    input = input.Replace(bannedWord, new string('*', bannedWord.Length));
                }
            }
            Console.Write(input);
        }
    }
}