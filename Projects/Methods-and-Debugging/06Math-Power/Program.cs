using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            RaiseToPow(input, pow);
        }
        static double RaiseToPow(double input, int pow)
        {
            double result;
            result = Math.Pow(input, pow);
            Console.WriteLine(result);
            return result;
        }
    }
}

