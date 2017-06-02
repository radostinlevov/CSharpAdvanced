using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromTheSpecifiedLine
{
    class ReadFromTheSpecifiedLine
    {
        static void Main()
        {
            int startLineToRead = int.Parse(Console.ReadLine());

            string[] specifiedLines = File.ReadLines("file.txt").Skip(startLineToRead).ToArray();

            if (specifiedLines.Length == 0)
            {
                Console.WriteLine("Text over!");
            }
            else
            {
                Console.WriteLine(string.Join("\r\n", specifiedLines));
            }            
        }
    }
}
