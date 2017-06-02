using System;
using System.IO;

namespace SimpleJudge
{
    public static class OutputWriter
    {
        public static void WriteMessageOnNewLine(string textToPrint)
        {
            Console.WriteLine(textToPrint);
        }
    }

    public static class Tester
    {
        public static void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            OutputWriter.WriteMessageOnNewLine("Reading files...");

            string mismatchPath = GetMismatchPath(expectedOutputPath);

            string[] actualOutputLines = File.ReadAllLines(userOutputPath);
            string[] expextedOutputLines = File.ReadAllLines(expectedOutputPath);

            bool hasMismatch;
            string[] mismatches = GetLinesWithPossibleMismatches(actualOutputLines, expextedOutputLines, out hasMismatch);

            PrintOutput(mismatches, hasMismatch, mismatchPath);
            OutputWriter.WriteMessageOnNewLine("Files read!");
        }
        
        private static void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatches)
                {
                    OutputWriter.WriteMessageOnNewLine(line);
                }

                File.WriteAllLines(mismatchPath, mismatches);
            }
            else
            {
                const string messageIdentical = "Files are identical. There are no mismatches.";
                OutputWriter.WriteMessageOnNewLine(messageIdentical);
                File.WriteAllText(mismatchPath, messageIdentical);
            }
        }

        private static string[] GetLinesWithPossibleMismatches(string[] actualOutputLines, string[] expextedOutputLines, out bool hasMismatch)
        {
            hasMismatch = false;
            string output = string.Empty;

            string[] mismatches = new string[actualOutputLines.Length];
            OutputWriter.WriteMessageOnNewLine("Comparing files...");

            for (int i = 0; i < actualOutputLines.Length; i++)
            {
                string actualLine = actualOutputLines[i];
                string expectedLine = expextedOutputLines[i];
              
                if (actualLine != expectedLine)
                {
                    output = $"Mismatch at line {i} --expected: \"{expectedLine}\", actual: \"{actualLine}\"";
                    output += Environment.NewLine;
                    hasMismatch = true;
                }
                else
                {
                    output = actualLine;
                    output += Environment.NewLine;
                }
                mismatches[i] = output;
            }
            return mismatches;
        }

        private static string GetMismatchPath(string expectOutputPath)
        {
            int indexOf = expectOutputPath.LastIndexOf('\\');
            string directoryPath = expectOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Mismatches.txt";
            return finalPath;
        }
    }
    class SimpleJudge
    {
        static void Main()
        {
            Tester.CompareContent(@"D:\Programming\Visual Studio 2015\Projects\C# Advanced\Lab-FilesAndDirectories\SimpleJudge\test1.txt", @"D:\Programming\Visual Studio 2015\Projects\C# Advanced\Lab-FilesAndDirectories\SimpleJudge\test2.txt");


        }
    }
}
