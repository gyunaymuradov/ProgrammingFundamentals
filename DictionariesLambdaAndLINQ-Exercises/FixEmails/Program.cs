using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> emailDictionary = new Dictionary<string, string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    foreach (var person in emailDictionary)
                    {
                        Console.WriteLine($"{person.Key} -> {person.Value}");
                    }
                    break;
                }
                var email = Console.ReadLine();

                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    continue;
                }
                emailDictionary.Add(name, email);
            }
        }
    }
}
