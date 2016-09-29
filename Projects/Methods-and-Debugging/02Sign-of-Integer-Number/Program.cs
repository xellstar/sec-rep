﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Sign_of_Integer_Number
{
    class Program
    {
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number == 0)
            {
                Console.WriteLine("The number {0} is zero.",number);
            }
            else
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
