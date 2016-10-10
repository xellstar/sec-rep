using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var offdays = double.Parse(Console.ReadLine());
            var workdays = 365 - offdays;
            var play = (offdays * 127) + (workdays * 63);


            if (play > 30000)
            {
                var time = play - 30000;
                var hours = (int)time / 60;
                var minutes = time % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",hours,minutes);
            }
            if (play < 30000)
            {
                var time = 30000 - play;
                var hours = (int)time / 60;
                var minutes = time % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }

        } 
    }
}
