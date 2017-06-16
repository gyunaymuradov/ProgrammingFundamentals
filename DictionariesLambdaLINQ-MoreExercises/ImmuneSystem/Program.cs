using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialHealth = double.Parse(Console.ReadLine());
            var line = Console.ReadLine();
            var virusDict = new Dictionary<string, int>();
            var health = initialHealth;
            var remainingHealth = 0.0;

            while (line != "end")
            {
                var lettersSum = 0;
                foreach (var letter in line)
                {
                    lettersSum += letter;
                }
                var virusStrength = lettersSum / 3;
                var defeatTime = 0;
                if (!virusDict.ContainsKey(line))
                {
                    defeatTime = virusStrength * line.Length;
                    virusDict[line] = virusStrength;
                }
                else
                {
                    defeatTime = (virusStrength * line.Length) / 3;
                }
                var timeInMinutes = defeatTime / 60;
                var timeInSeconds = defeatTime % 60;

                Console.WriteLine($"Virus {line}: {virusStrength} => {defeatTime} seconds");
                if (health - defeatTime > 0)
                {
                    Console.WriteLine($"{line} defeated in {timeInMinutes}m {timeInSeconds}s.");
                    health -= defeatTime;
                    Console.WriteLine($"Remaining health: {health}");
                    int regen = (int)(health * 0.2);

                    health += regen;
                    if (health > initialHealth)
                    {
                        health = initialHealth;
                    }
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                line = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {health}");
        }
    }
}