using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugsinLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] ladybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> AllLadyBugs = new List<int>();
            for (int i = 0; i < ladybugs.Length; i++)
            {
                AllLadyBugs.Add(ladybugs[i]);
            }
            string[] directions = Console.ReadLine().Split();


            while (!directions[0].Equals("end"))
            {
                int moveItem = int.Parse(directions[0]);
                int toPlace = int.Parse(directions[2]);
                if (directions[1] == "right")
                {
                    for (int i = 0; i < toPlace; i++)
                    {
                        for (int j = 0; j < moveItem; j++)
                        {
                            if (moveItem > AllLadyBugs.Count)
                            {
                                AllLadyBugs.Add(0);
                            }
                        }
                        var first = AllLadyBugs[moveItem];
                        AllLadyBugs.RemoveAt(moveItem);
                        AllLadyBugs.Insert(moveItem + 1, first);
                    }
                }
                if (directions[1] == "left")
                {
                    for (int i = moveItem; i >= toPlace; i--)
                    {
                        for (int j = 0; j < moveItem; j++)
                        {
                            if (moveItem > AllLadyBugs.Count)
                            {
                                AllLadyBugs.Add(0);
                            }
                        }
                        var first = AllLadyBugs[moveItem];
                        AllLadyBugs.RemoveAt(moveItem);
                        AllLadyBugs.Insert(moveItem + 1, first);
                    }
                }
                directions = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", AllLadyBugs));
        }
    }
}
