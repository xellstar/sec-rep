using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            //RegEx for digits and "." or "+" -     \+?-?[\d\.\d]+|\d
            //RegEx for matching how much times the damage should be multiplied -    \*
            //RegEx for matching every letter -     [A-Za-z]
            char[] separators = { ',', ' ' };
            string input = Console.ReadLine();
            string[] inputArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string rgx1 = @"\+?-?[\d\.\d]+|\d";
            string rgx2 = @"[\*]";
            string rgx3 = @"[A-Za-z]";
            string rgx4 = @"[/]";
            MatchCollection matchList = Regex.Matches(input, rgx1);
            var list = matchList.Cast<Match>().Select(match => match.Value).ToList();
            double damage = 0.0;
            for (int i = 0; i < list.Count; i++)
            {
                damage += double.Parse(list[i]);
            }
            int countMultiple = 1;
            int countDivider = 1;
            MatchCollection matchList2 = Regex.Matches(input, rgx2);
            foreach (var element in matchList2)
            {
                countMultiple++;
            }
            MatchCollection matchList3 = Regex.Matches(input, rgx3);
            foreach (var element in matchList3)
            {
                countDivider++;
            }
            Console.WriteLine("{0} - {2} damage", inputArray.Last(), 
                damage*(countMultiple*2)/countDivider);
        }
    }
}
