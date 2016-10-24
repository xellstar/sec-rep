using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMaraton
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long lapLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());
            if (runners > trackCapacity*days)
            {
                runners = trackCapacity*days;
            }
            long totalMeters = runners * laps * lapLength;
            long totalKilometers = totalMeters / 1000;
            decimal moneyRaised = totalKilometers * moneyPerKm;
            if (moneyRaised >= 0)
            {
                if (days >= 0 && days <= 365 && runners >= 0 && runners <= 2147483647 && laps >= 0
                    && laps <= 2147483647 && trackCapacity >= 0 && trackCapacity <= 1000)
                {
                    Console.WriteLine("Money raised: {0:N2}", moneyRaised);
                }
            }
            else
            {
                Console.WriteLine("Money raised: 0.00");
            }
        }
    }
}
