using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split(':');
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            Dictionary<string, int> playersScore = new Dictionary<string, int>();

            while (inputLine[0] != "JOKER")
            {
                string name = inputLine[0];
                List<string> inputCards = inputLine[1]
                                     .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                     .ToList();



                if (!players.ContainsKey(name))
                {
                    players.Add(name, inputCards);
                }
                else
                {
                    players[name].AddRange(inputCards);
                }

                inputLine = Console.ReadLine().Split(':');
            }

            CalcPlayerScpre(players, playersScore);

            foreach (var kvp in playersScore)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        private static void CalcPlayerScpre(Dictionary<string, List<string>> players, Dictionary<string, int> playersScore)
        {
            foreach (var kvp in players)
            {
                int sumScore = 0;

                foreach (var card in kvp.Value.Distinct())
                {
                    string digit = card.Substring(0, card.Length - 1);
                    string type = card.Substring(card.Length - 1);
                    int digitPower = 0;
                    int typePower = 0;

                    switch (digit)
                    {
                        case "2":
                            digitPower = 2;
                            break;
                        case "3":
                            digitPower = 3;
                            break;
                        case "4":
                            digitPower = 4;
                            break;
                        case "5":
                            digitPower = 5;
                            break;
                        case "6":
                            digitPower = 6;
                            break;
                        case "7":
                            digitPower = 7;
                            break;
                        case "8":
                            digitPower = 8;
                            break;
                        case "9":
                            digitPower = 9;
                            break;
                        case "10":
                            digitPower = 10;
                            break;
                        case "J":
                            digitPower = 11;
                            break;
                        case "Q":
                            digitPower = 12;
                            break;
                        case "K":
                            digitPower = 13;
                            break;
                        case "A":
                            digitPower = 14;
                            break;

                        default:
                            digitPower = 0;
                            break;
                    }

                    switch (type)
                    {
                        case "S":
                            typePower = 4;
                            break;
                        case "H":
                            typePower = 3;
                            break;
                        case "D":
                            typePower = 2;
                            break;
                        case "C":
                            typePower = 1;
                            break;

                        default:
                            typePower = 0;
                            break;
                    }
                    sumScore += digitPower * typePower;
                }

                if (!playersScore.ContainsKey(kvp.Key))
                {
                    playersScore.Add(kvp.Key, sumScore);
                }
                else
                {
                    playersScore[kvp.Key] += sumScore;
                }
            }
        }
    }
}
