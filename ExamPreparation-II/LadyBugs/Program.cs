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
            var index = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var lbList = new List<int>();
            for (int i = 0; i < fieldSize; i++)
            {
                if (index.Contains(i))
                {
                    lbList.Add(1);
                }
                else
                {
                    lbList.Add(0);
                }
            }
            var input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.Split(' ').ToList();
                var lbIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);
                if (flyLength < 0)
                {
                    direction = "right";
                }
                if (lbIndex < 0 || lbIndex > lbList.Count - 1 || lbList[lbIndex] == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (direction == "right")
                {

                    if (flyLength + lbIndex >= lbList.Count)
                    {
                        lbList[lbIndex] = 0;
                        input = Console.ReadLine();
                        continue;
                    }
                    var landingIndex = Math.Abs(flyLength) + lbIndex;
                    lbList[lbIndex] = 0;
                    if (lbList[landingIndex] == 0)
                    {
                        lbList[landingIndex] = 1;
                    }
                    else
                    {
                        while (lbList[landingIndex] == 1)
                        {
                            landingIndex += flyLength;
                            if (landingIndex >= lbList.Count)
                            {
                                break;
                            }
                            if (lbList[landingIndex] == 0)
                            {
                                lbList[landingIndex] = 1;
                                break;
                            }
                        }
                    }
                }
                else if (direction == "left")
                {
                    var landingIndex = lbIndex - flyLength;
                    lbList[lbIndex] = 0;
                    if (landingIndex < 0)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    if (lbList[landingIndex] == 0)
                    {
                        lbList[landingIndex] = 1;
                    }
                    else
                    {
                        while (lbList[landingIndex] == 1)
                        {
                            landingIndex -= flyLength;
                            if (landingIndex < 0)
                            {
                                break;
                            }
                            if (lbList[landingIndex] == 0)
                            {
                                lbList[landingIndex] = 1;
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", lbList));
        }
    }
}