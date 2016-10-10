using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = int.Parse(Console.ReadLine());
            BigInteger newNum = 1;
            for (int i = 2; i <= input; i++)
            {
                newNum *= i;
            }
            Console.WriteLine(newNum);
        }
    }
}
