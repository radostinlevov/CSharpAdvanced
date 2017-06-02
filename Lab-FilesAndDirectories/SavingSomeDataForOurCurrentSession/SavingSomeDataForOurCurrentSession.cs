using System.IO;

namespace SavingSomeDataForOurCurrentSession
{
    public static class SessionData
    {
        public static string currentPath = Directory.GetCurrentDirectory();              
    }

    class SavingSomeDataForOurCurrentSession
    {
        static void Main()
        {
            string currentPath = SessionData.currentPath;
            System.Console.WriteLine(currentPath);
        }
    }
}
