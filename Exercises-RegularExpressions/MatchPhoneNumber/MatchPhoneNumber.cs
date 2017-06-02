using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            string pattern = @"^\+359([ |-])2\1\d{3}\1\d{4}\b";
            List<string> validNumbers = new List<string>();

            while (number != "end")
            {
                bool isMatch = Regex.IsMatch(number, pattern);

                if (isMatch)
                {
                    validNumbers.Add(number);
                }

                number = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\r\n", validNumbers));
        }
    }
}
