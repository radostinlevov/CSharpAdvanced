using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                                   .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string bannedWord = bannedWords[i];
                string pattern = new string('*', bannedWord.Length);
                text = text.Replace(bannedWord, pattern);
            }

            Console.WriteLine(text);
        }
    }
}
