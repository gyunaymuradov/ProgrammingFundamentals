using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfChars = int.Parse(Console.ReadLine());
            var text = string.Empty;
            var space = string.Empty;

            for (int i = 0; i < numOfChars; i++)
            {
                var numCombo = int.Parse(Console.ReadLine());
                var digits = 0;
                var mainDigit = numCombo;
                var letterIndex = 0;
                var letter = 0;
                var smallA = 97;

                if (numCombo == 0)
                {
                    smallA = 32;
                }
                else
                {
                    while (mainDigit > 9)
                    {
                        mainDigit /= 10;
                    }
                    while (numCombo > 0)
                    {
                        numCombo /= 10;
                        digits++;
                    }
                    var offset = (mainDigit - 2) * 3;
                    if (mainDigit == 9 || mainDigit == 8)
                    {
                        offset++;
                    }
                    letterIndex = (offset + digits - 1);
                }
                letter = smallA + letterIndex;
                text += (char)letter;
            }
            Console.WriteLine(text);
        }
    }
}
