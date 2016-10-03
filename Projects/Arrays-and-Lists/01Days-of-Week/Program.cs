using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Days_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] days =
            {
                "Invalid day!",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (day <= 7 || day >=1)
            {
                Console.WriteLine(days[day]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
