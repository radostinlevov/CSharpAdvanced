using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMiner
{
    class TaskMiner
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> preciousMetals = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!preciousMetals.ContainsKey(resource))
                {
                    preciousMetals.Add(resource, quantity);
                }
                else
                {
                    preciousMetals[resource] += quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var kvp in preciousMetals)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
