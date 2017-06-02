using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main()
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!charsCount.ContainsKey(text[i]))
                {
                    charsCount.Add(text[i], 1);
                }
                else
                {
                    charsCount[text[i]]++;
                }
            }

            foreach (var kvp in charsCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
