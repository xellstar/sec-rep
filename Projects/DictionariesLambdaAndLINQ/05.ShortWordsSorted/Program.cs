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
            string input = Console.ReadLine().ToLower();
            int maxLength = 5;
            Console.WriteLine(string.Join(", ",getWordsWithMinLength(input, maxLength)));
        }
        static IEnumerable<string> getWordsWithMinLength(string input, int maxLength)
        {
            char[] separators = new char[] 
            { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
            string[] words = input.Split(separators);
            return words.Where(w => w.Length < maxLength)
                        .Where(w => w != "")
                        .OrderBy(w => w).Distinct();            
        }
    }
}
