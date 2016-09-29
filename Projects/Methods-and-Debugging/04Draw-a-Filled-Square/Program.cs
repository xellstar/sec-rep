using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintHeaderRow(input);
            PrintMiddleRow(input);
            PrintHeaderRow(input);
        }
        static void PrintHeaderRow(int input)
        {
            Console.WriteLine(new string('-', input * 2));
        }
        static void PrintMiddleRow(int input)
        {
            for (int i = 0; i < input-2; i++)
            {
                Console.Write("-");
                for (int i1 = 1; i1 < input; i1++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
