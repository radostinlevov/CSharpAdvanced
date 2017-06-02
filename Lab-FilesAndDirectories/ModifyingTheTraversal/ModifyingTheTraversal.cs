using System;
using System.Collections.Generic;
using System.IO;
using SavingSomeDataForOurCurrentSession;

namespace ModifyingTheTraversal
{
    public static class OutputWriter
    {
        public static void WriteEmptyLine()
        {
            string newLine = Environment.NewLine;
            Console.Write(newLine);
        }
    }

    class ModifyingTheTraversal
    {
        static void Main()
        {
            string currentPath = SessionData.currentPath;

            OutputWriter.WriteEmptyLine();
            int initialIdentation = currentPath.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(SessionData.currentPath);



            Console.WriteLine(subFolders.Dequeue());

            foreach (var file in Directory.GetFiles(currentPath))
            {
                int depth = currentPath.Split('\\').Length + 1;
                if (depth - initialIdentation < 0)
                {
                    break;
                }

                int indexOfLastSlash = currentPath.LastIndexOf('\\');
                string fileName = file.Substring(indexOfLastSlash);
                Console.WriteLine($"{new string('-', indexOfLastSlash)}{fileName}");
            }

            foreach (var directory in Directory.GetDirectories(currentPath))
            {
                Console.WriteLine("-" + directory);
            }
        }
    }
}
