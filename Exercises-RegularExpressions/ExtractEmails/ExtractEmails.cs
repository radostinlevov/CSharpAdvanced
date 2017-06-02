using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"[^\.\-_]\b[A-Za-z0-9]+[\.|\-|_]?[A-Za-z0-9]*@[A-Za-z]+\-?[A-Za-z]+\.[A-Za-z]*\.?[A-Za-z]*\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                for (int i = 0; i < match.Groups.Count; i++)
                {
                    string email = match.Groups[i].ToString();
                    Console.WriteLine(email.Trim());
                }
            }
        }
    }
}
