using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingDirectories
{
    class ChangingDirectories
    {
        static void Main()
        {
            string relativePath = Console.ReadLine();
            ChangeCurrentDirectoryRelative(relativePath);
            Console.WriteLine(SessionData.currentPath);
        }

        private static void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                string currentPath = SessionData.currentPath;
                int indexOfLastSlash = currentPath.LastIndexOf('\\');
                string newPath = currentPath.Substring(0, indexOfLastSlash);
                SessionData.currentPath = newPath;
            }
            else
            {
                string currentPath = SessionData.currentPath;
                currentPath += "\\" + relativePath;
                changeCurrentDirectoryAbsolute(currentPath);
            }
           
        }

        private static void changeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (Directory.Exists(absolutePath))
            {
                OutputWriter.DisplayException(ExceptionMessage.InvalidPath);
                return;
            }

            SessionData.currentPath = absolutePath;
        }
    }
}
