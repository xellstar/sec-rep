using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _04.RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split();           
            List<string> inputList = new List<string>();
            inputList.AddRange(inputArray);
            if (input != "Time for Code")
            {
                int eventID = int.Parse(inputList[0]);
                string[] eventName = inputList[1].Split('#');
                string rgx = "\\@\\w+";
                int inputListCount = inputList.Count;
                Regex regex = new Regex(rgx);
                List<string> participants = new List<string>();
                StringBuilder sb1 = new StringBuilder();
                MatchCollection collection = regex.Matches(input);
                foreach (Match match in collection)
                {
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        sb1.Append(match.Groups[1]);
                    }
                }
                inputArray = Console.ReadLine().Split();
            }
            else
            {
                Console.WriteLine(string.Join(" ", inputList));
                Console.WriteLine(string.Join(" ", inputArray));
            }
        }
    }
}
