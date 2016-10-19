using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            decimal total = 0;
            List<decimal> sums = new List<decimal>();
            for (int i = 0; i < n; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);              
                int count = int.Parse(Console.ReadLine());
                int thedate = DateTime.DaysInMonth(date.Year, date.Month);
                sum = count*(price*thedate);
                total += sum;
                sums.Add(sum);
            }
            for (int i = 0; i < sums.Count; i++)
            {
                Console.WriteLine("The price for the coffee is: ${0:0.00}", sums[i]);
            }
            Console.WriteLine($"Total: ${total:0.00}");

        }
    }
}
