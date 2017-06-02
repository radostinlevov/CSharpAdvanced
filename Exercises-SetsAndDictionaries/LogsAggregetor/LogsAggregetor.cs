using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregetor
{
    class LogsAggregetor
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var listByLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split();

                string user = inputLine[1];
                string ip = inputLine[0];
                int duration = int.Parse(inputLine[2]);

                if (!listByLogs.ContainsKey(user))
                {
                    listByLogs.Add(user, new SortedDictionary<string, int>());
                    listByLogs[user].Add(ip, duration);
                }
                else if (!listByLogs[user].ContainsKey(ip))
                {
                    listByLogs[user].Add(ip, duration);
                }
                else
                {
                    listByLogs[user][ip] += duration;
                }
            }

            foreach (var outerPair in listByLogs)
            {
                var keysAsList = outerPair.Value.Keys.ToList();

                Console.Write($"{outerPair.Key}: {outerPair.Value.Values.Sum()} [{string.Join(", ", keysAsList)}]");
                Console.WriteLine();
            }
        }
    }
}
