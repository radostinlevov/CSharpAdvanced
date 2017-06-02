using System;

namespace StringLength
{
    public class StringLength
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string partOfText = string.Empty;

            if (text.Length <= 20)
            {
                partOfText = text.Substring(0, text.Length);
            }
            else
            {
                partOfText = text.Substring(0, 20);
            }

            string paddingText = partOfText.PadRight(20, '*');
            Console.WriteLine(paddingText);
        }
    }
}
