using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            GetMax(first, second);
        }
        static int GetMax(int type, int first, int second)
        {
                if (first >= second)
                {
                    Console.WriteLine(first);
                    return first;
                }
                else
                {
                    Console.WriteLine(second);
                    return second;
                }
            
        }
        //static char GetMax(char first, char second)
       // {
            
       // }
        static string GetMax(string first, string second)
        {
            Console.WriteLine(string.Compare(first,second));
            return first;
        }
    }
}
