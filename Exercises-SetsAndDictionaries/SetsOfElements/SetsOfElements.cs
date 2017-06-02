using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main()
        {
            string[] numberInput = Console.ReadLine().Split();
            int n = int.Parse(numberInput[0]);
            int m = int.Parse(numberInput[1]);
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                firstSet.Add(digit);
            }

            for (int i = 0; i < m; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                secondSet.Add(digit);
            }

            int[] intersectElements = firstSet.Intersect(secondSet).ToArray();

            Console.WriteLine(string.Join(" ", intersectElements));
        }
    }
}
