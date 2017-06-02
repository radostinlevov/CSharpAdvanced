using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTag
{
    public class ReplaceTag
    {
        public static void Main()
        {
            string tag = Console.ReadLine();
            string pattern = @"(.*\s*)<a.*href=(\s*.+)>(\s*.+)<\/a>(\s*.*)";
            string replacement = "$1[URL href=$2]$3[/URL]$4";
            List<string> replacedTags = new List<string>();
            while (tag != "end")
            {
                string replacedTag = Regex.Replace(tag, pattern, replacement);

                replacedTags.Add(replacedTag);

                tag = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\r\n", replacedTags));
        }
    }
}
