using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiters = new char[] { '&', '?' };
            var inputLine = Console.ReadLine();
            var pattern = @"\+|%20";
            Regex regex = new Regex(pattern);
            List<Dictionary<string, List<string>>> allFieldsValues = new List<Dictionary<string, List<string>>>();

            while (inputLine != "END")
            {
                var text = inputLine.Split(delimiters);
                List<string> pairs = new List<string>();

                foreach (var item in text)
                {
                    if (item.Contains("="))
                    {
                        pairs.Add(item);
                    }
                }

                Dictionary<string, List<string>> orderedPairs = new Dictionary<string, List<string>>();

                for (int i = 0; i < pairs.Count; i++)
                {
                    var pair = pairs[i];
                    pair = regex.Replace(pair, " ");
                    var splitedPair = pair.Split('=');
                    var field = splitedPair[0].Trim();
                    var value = splitedPair[1].Trim();
                    field = Regex.Replace(field, @"\s+", " ");
                    value = Regex.Replace(value, @"\s+", " ");

                    if (!orderedPairs.ContainsKey(field))
                    {
                        orderedPairs[field] = new List<string>();
                    }

                    orderedPairs[field].Add(value);
                }

                allFieldsValues.Add(orderedPairs);
                inputLine = Console.ReadLine();
            }

            foreach (var fieldValueInRow in allFieldsValues)
            {
                foreach (var item in fieldValueInRow)
                {
                    var field = item.Key;
                    var values = item.Value;
                    Console.Write($"{field}=[" + string.Join(", ", values) + "]");
                }
                Console.WriteLine();
            }
        }
    }
}