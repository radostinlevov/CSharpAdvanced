using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
   public class SeriesOfLetters
    {
       public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(.)\1+";

            string replacedInput = Regex.Replace(input, pattern, "$1");
            Console.WriteLine(replacedInput);
        }
    }
}
