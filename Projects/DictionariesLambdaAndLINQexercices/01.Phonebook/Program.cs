using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isEnd = false;

            if (input == "END")
            {
                isEnd = true;
            }
            else
            {
                isEnd = false;
            }
            while (isEnd  == false)
            {
                string[] array = input.Split(null);

            }
        }
    }
}
