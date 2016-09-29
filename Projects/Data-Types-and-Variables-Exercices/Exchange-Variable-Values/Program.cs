using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int aAfter = 0;
            int bAfter = 0;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            aAfter = b;
            bAfter = a;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", aAfter);
            Console.WriteLine("b = {0}", bAfter);
        }
    }
}
