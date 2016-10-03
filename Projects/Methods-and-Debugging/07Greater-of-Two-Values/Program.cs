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

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                var max = MaxInt(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                var first = char.Parse(Console.ReadLine());
                var second = char.Parse(Console.ReadLine());
                var max = MaxChar(first, second);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                var max = MaxString(first, second);
                Console.WriteLine(max);
            }
        }
        static int MaxInt(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }            
        }
        static char MaxChar(char first, char second)
        {
            if (first>=second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string MaxString(string first, string second)
        {
            if (first.CompareTo(second) == 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
