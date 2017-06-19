using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var registryDict = new Dictionary<string, string>();

            for (int i = 0; i < lines; i++)
            {
                var token = Console.ReadLine().Split(' ');
                var command = token[0];
                var name = token[1];

                if (command == "register")
                {
                    var plate = token[2];
                    bool isValid = CheckIfPlateIsValid(plate);

                    if (registryDict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registryDict[name]}");
                    }
                    else if (registryDict.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }
                    else
                    {
                        if (!isValid)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {plate}");
                        }
                        else
                        {
                            registryDict[name] = plate;
                            Console.WriteLine($"{name} registered {plate} successfully");
                        }
                    }
                }
                else
                {
                    if (registryDict.ContainsKey(name))
                    {
                        Console.WriteLine($"user {name} unregistered successfully");
                        registryDict.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var plate in registryDict)
            {
                Console.WriteLine($"{plate.Key} => {plate.Value}");
            }
        }

        static bool CheckIfPlateIsValid(string plate)
        {
            if (plate.Length != 8)
            {
                return false;
            }
            foreach (var letter in plate.Take(2))
            {
                if (!char.IsLetter(letter))
                {
                    return false;
                }
                if (!char.IsUpper(letter))
                {
                    return false;
                }
            }
            foreach (var letter in plate.Reverse().Take(2))
            {
                if (!char.IsLetter(letter))
                {
                    return false;
                }
                if (!char.IsUpper(letter))
                {
                    return false;
                }
            }
            foreach (var number in plate.Skip(2).Take(4))
            {
                if (!char.IsDigit(number))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
