using System;
using System.Collections.Generic;
using System.Linq;
 
class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        double inputDouble = 0;
        inputDouble = Convert.ToInt64(input);
        double immuneSystemHealth = 0;
        immuneSystemHealth = inputDouble;
        var virus = Console.ReadLine().ToList();;
        var foughtVirusesList = new List<int>();
        while (string.Join("", virus) != "end")
        {
            int virusStrenghtCalculated = 0;
            int virusTimeToDefeatSeconds = 0;
            string virusTimeToDeafeatMinutesFormatted = string.Empty;
 
            for (int i = 0; i < virus.Count; i++)
            {
                virusStrenghtCalculated += virus[i];                                  
            }
            virusStrenghtCalculated /= 3;
           
            virusTimeToDefeatSeconds = virusStrenghtCalculated * virus.Count();
            for (int i = 0; i < foughtVirusesList.Count; i++)
            {
                if (virusStrenghtCalculated == foughtVirusesList[i])
                {
                    virusTimeToDefeatSeconds = (virusStrenghtCalculated * virus.Count()) / 3;
                }                                              
            }
            foughtVirusesList.Add(virusStrenghtCalculated);
            double seconds = virusTimeToDefeatSeconds % 60;
            double minutes = virusTimeToDefeatSeconds / 60;
            Convert.ToInt32(immuneSystemHealth);
            immuneSystemHealth -= virusTimeToDefeatSeconds;
           
           
            if (immuneSystemHealth > 0)
            {
                Console.WriteLine($"Virus {string.Join("", virus)}: {virusStrenghtCalculated} => {virusTimeToDefeatSeconds} seconds" +
                    $"\n{string.Join("", virus)} defeated in {minutes}m {seconds}s.\nRemaining health: {(int)immuneSystemHealth}");
                Math.Floor(immuneSystemHealth);
                   immuneSystemHealth += (int)(immuneSystemHealth * 0.20);
                Convert.ToInt32(immuneSystemHealth);
                if (immuneSystemHealth > inputDouble)
                {
                    immuneSystemHealth = inputDouble;
                }
            }
            else
            {
                Console.WriteLine($"Virus {string.Join("", virus)}: {virusStrenghtCalculated} => {virusTimeToDefeatSeconds} seconds");
                Console.WriteLine("Immune System Defeated.");
                return;
            }
 
            virus = Console.ReadLine().ToList();
        }
        Console.WriteLine($"Final Health: {Math.Floor(immuneSystemHealth)}");
 
 
    }
}