using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var lbIndexes = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            List<int> ladyBugList = CreateLadyBugField(fieldSize, lbIndexes);
            var command = Console.ReadLine();

            while (command != "end")
            {
                var tokens = command.Split(' ').ToList();
                var ladyBugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);
                if (flyLength < 0)
                {
                    direction = "right";
                }
                if (ladyBugIndex < 0 || ladyBugIndex >= ladyBugList.Count || ladyBugList[ladyBugIndex] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }
                ladyBugList[ladyBugIndex] = 0;
                if (direction == "right")
                {
                    var landingIndex = ladyBugIndex + Math.Abs(flyLength);
                    if (landingIndex >= ladyBugList.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    if (ladyBugList[landingIndex] == 1)
                    {
                        while (landingIndex <= ladyBugList.Count)
                        {
                            landingIndex += flyLength;
                            if (landingIndex >= ladyBugList.Count)
                            {
                                break;
                            }
                            if (ladyBugList[landingIndex] == 0)
                            {
                                ladyBugList[landingIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        ladyBugList[landingIndex] = 1;
                    }
                }
                else
                {
                    var landingIndex = ladyBugIndex - flyLength;
                    if (landingIndex < 0)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    if (ladyBugList[landingIndex] == 1)
                    {
                        while (landingIndex >= 0)
                        {
                            landingIndex -= flyLength;
                            if (landingIndex < 0)
                            {
                                break;
                            }
                            if (ladyBugList[landingIndex] == 0)
                            {
                                ladyBugList[landingIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        ladyBugList[landingIndex] = 1;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladyBugList));
        }
        private static List<int> CreateLadyBugField(int fieldSize, long[] lbIndexes)
        {
            var lbList = new List<int>();
            for (int i = 0; i < fieldSize; i++)
            {
                if (lbIndexes.Contains(i))
                {
                    lbList.Add(1);
                }
                else
                {
                    lbList.Add(0);
                }
            }
            return lbList;
        }
    }
}