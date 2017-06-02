using System;
using System.Collections.Generic;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            string[] wordsOfText = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!', '\t', '\n' },
                                                      StringSplitOptions.RemoveEmptyEntries);
            bool isPalindrome = false;
            SortedSet<string> palindromes = new SortedSet<string>();

            for (int i = 0; i < wordsOfText.Length; i++)
            {
                string word = wordsOfText[i];

                if (word.Length == 1)
                {
                    isPalindrome = true;
                }

                for (int j = 0; j < word.Length / 2; j++)
                {
                    if (word[j] == word[word.Length - 1 - j])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine($"[{string.Join(", ", palindromes)}]");
        }
    }
}
