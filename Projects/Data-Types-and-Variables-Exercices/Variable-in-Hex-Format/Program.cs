﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int numNew = Convert.ToInt32(num1, 16);
            Console.WriteLine(numNew);
        }
    }
}
