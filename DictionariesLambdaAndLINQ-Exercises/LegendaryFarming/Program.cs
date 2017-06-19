using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterialDict = new Dictionary<string, long>();
            keyMaterialDict["shards"] = 0;
            keyMaterialDict["fragments"] = 0;
            keyMaterialDict["motes"] = 0;
            var notKeyMaterialDict = new Dictionary<string, long>();

            bool itemObtained = false;
            var input = Console.ReadLine().Split(' ').ToList();

            while (!itemObtained)
            {
                for (int i = 0; i < input.Count - 1; i += 2)
                {
                    var quantity = long.Parse(input[i]);
                    var material = input[i + 1].ToLower();

                    if (material == "shards")
                    {
                        keyMaterialDict["shards"] += quantity;
                    }
                    else if (material == "fragments")
                    {
                        keyMaterialDict["fragments"] += quantity;
                    }
                    else if (material == "motes")
                    {
                        keyMaterialDict["motes"] += quantity;
                    }
                    else
                    {
                        if (!notKeyMaterialDict.ContainsKey(material.ToLower()))
                        {
                            notKeyMaterialDict[material.ToLower()] = 0;
                        }
                        notKeyMaterialDict[material.ToLower()] += quantity;
                    }

                    if (keyMaterialDict["fragments"] >= 250)
                    {
                        keyMaterialDict["fragments"] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        itemObtained = true;
                        break;
                    }
                    if (keyMaterialDict["motes"] >= 250)
                    {
                        keyMaterialDict["motes"] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        itemObtained = true;
                        break;
                    }
                    if (keyMaterialDict["shards"] >= 250)
                    {
                        keyMaterialDict["shards"] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        itemObtained = true;
                        break;
                    }
                }
                if (!itemObtained)
                {
                    input = Console.ReadLine().Split().ToList();
                }
            }

            var keyMaterialsOrderedDescendingAndAlphabetically = keyMaterialDict.OrderByDescending(a => a.Value).ThenBy(b => b.Key);

            if (itemObtained)
            {

            }
            foreach (var material in keyMaterialsOrderedDescendingAndAlphabetically)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in notKeyMaterialDict.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}