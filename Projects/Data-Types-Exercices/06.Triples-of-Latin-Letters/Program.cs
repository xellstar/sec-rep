using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i1 = 0; i1 < num; i1++)
            {
                for (int i2 = 0; i2 < num; i2++)
                {
                    for (int i3 = 0; i3 < num; i3++)
                    {
                        char letter = (char)('a' + i1);
                        char letter2 = (char)('a' + i2);
                        char letter3 = (char)('a' + i3);
                        Console.WriteLine("{0}{1}{2}",letter,letter2,letter3);
                    }
                }
            }
        }
    }
}
