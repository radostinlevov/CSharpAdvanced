using System;
using System.Collections.Generic;

namespace UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            List<string> unicodeChars = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string unicodeChar = "\\u" + Convert.ToString(((int)text[i]), 16).PadLeft(4, '0');
                unicodeChars.Add(unicodeChar);
            }

            Console.WriteLine(string.Join("", unicodeChars));
        }
    }
}
