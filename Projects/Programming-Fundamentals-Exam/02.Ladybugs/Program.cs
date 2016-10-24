using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            string[] ladybugs = Console.ReadLine().Split();
            int[] allLadyBugs = new int[sizeOfTheField];
            string[] directions = Console.ReadLine().Split();
            int count = 0;
            int start = int.Parse(directions[0]);
            int moveBy = int.Parse(directions[2]);
            for (int i = 0; i < start; i++)
            {
                if (directions[0] != "end")
                {
                    for (int j = 0; j < count; j++)
                    {
                        allLadyBugs[count] = 1;
                        count++;
                    }
                    if (directions[1] == "right")
                    {

                        for (int k = 0; k < sizeOfTheField; k++)
                        {
                            allLadyBugs[start] = allLadyBugs[start+1];
                            if (start > allLadyBugs.Length)
                            {
                             
                            }
                        }
                    }
                    if (directions[1] == "left")
                    {
                        for (int k = moveBy; k > 0; k--)
                        {
                            allLadyBugs[k] = allLadyBugs[k - 1];
                        }
                    }
                }
                directions = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", allLadyBugs));
        }
    }
}
