using System.IO;

namespace MakingDirectories
{
    public static class IOManager
    {
        public static void CreateDirectoryInCurrentFolder(string name)
        {
            string path = GetCurrentDirectoryPath() + "\\" + name;
            Directory.CreateDirectory(path);
        }

        private static string GetCurrentDirectoryPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            return currentPath;
        }
    }

    class MakingDirectories
    {
        static void Main()
        {
            IOManager.CreateDirectoryInCurrentFolder("Rado");
        }
    }
}
