using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int Centuries = int.Parse(Console.ReadLine());
            int years = Centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", Centuries, years, days, hours, minutes);
        }
    }
}
