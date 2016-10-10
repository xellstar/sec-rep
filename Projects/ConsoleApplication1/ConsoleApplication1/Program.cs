using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var PriceVeg = double.Parse(Console.ReadLine());
            var PriceFruit = double.Parse(Console.ReadLine());
            var WeightVeg = int.Parse(Console.ReadLine());
            var WeightFruit = int.Parse(Console.ReadLine());

            var TotalVeg = PriceVeg * WeightVeg;
            var TotalFruit = PriceFruit * WeightFruit;

            var TotalPrice = (TotalFruit + TotalVeg) / 1.94;

            Console.WriteLine(TotalPrice);
        }
    }
}
