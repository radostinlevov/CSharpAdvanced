using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            bool winRace = false;

            GetInput(ref input, keyMaterials, junkMaterials, ref winRace);

            PrintObtainedItem(keyMaterials);

            var keyMaterialsOrdered = keyMaterials.OrderByDescending(p => p.Value).ThenBy(p => p.Key);
            foreach (var pair in keyMaterialsOrdered)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var pair in junkMaterials)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        private static void PrintObtainedItem(Dictionary<string, int> keyMaterials)
        {
            bool hasMatch = false;
            foreach (var pair in keyMaterials)
            {
                if (pair.Value >= 250)
                {
                    switch (pair.Key)
                    {
                        case "shards":
                            keyMaterials[pair.Key] = pair.Value - 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            break;
                        case "fragments":
                            keyMaterials[pair.Key] = pair.Value - 250;
                            Console.WriteLine($"Valanyr obtained!");
                            break;
                        case "motes":
                            keyMaterials[pair.Key] = pair.Value - 250;
                            Console.WriteLine($"Dragonwrath obtained!");
                            break;
                    }
                    hasMatch = true;
                }
                if (hasMatch)
                {
                    break;
                }
            }
        }

        private static void GetInput(ref string[] input, Dictionary<string, int> keyMaterials, SortedDictionary<string, int> junkMaterials, ref bool winRace)
        {
            while (input.Length > 0)
            {
                int quantity = 0;
                string material = null;

                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(input[i]);
                    }
                    else
                    {
                        material = input[i].ToLower();
                    }
                    if (i % 2 != 0)
                    {
                        if (!keyMaterials.ContainsKey(material))
                        {
                            if (!junkMaterials.ContainsKey(material))
                            {
                                junkMaterials.Add(material, 0);
                            }
                            junkMaterials[material] += quantity;
                        }
                        else
                        {
                            keyMaterials[material] += quantity;
                        }

                        if (keyMaterials["shards"] >= 250 ||
                            keyMaterials["fragments"] >= 250 ||
                            keyMaterials["motes"] >= 250)
                        {
                            winRace = true;
                            break;
                        }
                    }
                }
                if (winRace)
                {
                    break;
                }

                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
