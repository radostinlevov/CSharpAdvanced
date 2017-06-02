using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class UserLogs
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            var logsByUser = new SortedDictionary<string, Dictionary<string, int>>();

            while (!inputLine.Equals("end"))
            {
                string[] userInfo = inputLine.Split();
                string ip = userInfo[0].Substring(3);
                string user = userInfo[2].Substring(5);

                if (!logsByUser.ContainsKey(user))
                {
                    logsByUser.Add(user, new Dictionary<string, int>());
                    logsByUser[user].Add(ip, 0);
                }
                else if (!logsByUser[user].ContainsKey(ip))
                {
                    logsByUser[user].Add(ip, 0);
                }
                logsByUser[user][ip]++;

                inputLine = Console.ReadLine();
            }

            foreach (var pair in logsByUser)
            {
                Console.WriteLine($"{pair.Key}:");
                Console.WriteLine("{0}.", string.Join(", ", pair.Value
                              .Select(p => string.Format("{0} => {1}", p.Key, p.Value))));
            }
        }
    }
}
