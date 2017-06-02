using System;

namespace CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int index = text.IndexOf(pattern);
            int counter = 0;

            while (index >= 0 && index <= text.Length)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
