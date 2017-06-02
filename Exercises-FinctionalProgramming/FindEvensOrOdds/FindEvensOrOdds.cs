using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            int[] scope = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string typeNumber = Console.ReadLine();

            Predicate<int> findEvens = delegate (int a) { return a % 2 == 0; };
            Predicate<int> findOdds = delegate (int b) { return b % 2 != 0; };
            List<int> numbers = new List<int>();

            int startNum = scope[0];
            int endNum = scope[1];

            for (int i = startNum; i <= endNum; i++)
            {
                numbers.Add(i);
            }

            if (typeNumber == "even")
            {
                numbers = numbers.FindAll(findEvens);
                Console.WriteLine(string.Join(" ", numbers));
            }
            else if (typeNumber == "odd")
            {
                numbers = numbers.FindAll(findOdds);
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
