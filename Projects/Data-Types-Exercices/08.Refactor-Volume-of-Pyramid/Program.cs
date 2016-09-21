using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double Lenght, Width, Height = 0;
            Console.Write("Length: ");
            Lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            Height = double.Parse(Console.ReadLine());
            Height = (Lenght * Width * Height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", Height);

        }
    }
}
