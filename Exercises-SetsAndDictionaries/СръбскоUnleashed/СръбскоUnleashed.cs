using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace СръбскоUnleashed
{
    class СръбскоUnleashed
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            string pattern = @"(.+) @(.+) (\d+) (\d+)";
            Regex regex = new Regex(pattern);
            Dictionary<string, Dictionary<string, long>> singersByPlace = new Dictionary<string, Dictionary<string, long>>();

            while (inputLine != "End")
            {
                Match match = regex.Match(inputLine);
                if (match.Success)
                {
                    string place = match.Groups[2].Value;
                    string singer = match.Groups[1].Value;
                    int ticketsPrice = int.Parse(match.Groups[3].Value);
                    int ticketsCount = int.Parse(match.Groups[4].Value);
                    long sumOfTickets = ticketsPrice * ticketsCount;

                    if (!singersByPlace.ContainsKey(place))
                    {
                        singersByPlace.Add(place, new Dictionary<string, long>());
                        singersByPlace[place].Add(singer, sumOfTickets);
                    }
                    else if (!singersByPlace[place].ContainsKey(singer))
                    {
                        singersByPlace[place].Add(singer, sumOfTickets);
                    }
                    else
                    {
                        singersByPlace[place][singer] += sumOfTickets;
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var outerPair in singersByPlace)
            {
                Console.WriteLine(outerPair.Key);
                foreach (var innerPair in outerPair.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {innerPair.Key} -> {innerPair.Value}");
                }
            }
        }
    }
}
