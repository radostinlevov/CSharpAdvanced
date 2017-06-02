using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}";
            List<string> validNames = new List<string>();

            while (name != "end")
            {
                bool isMatch = Regex.IsMatch(name, pattern);

                if (isMatch)
                {
                    validNames.Add(name);
                }

                name = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\r\n", validNames));
        }
    }
}
