using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    public class ReverseAndExclude
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divider = int.Parse(Console.ReadLine());
            Func<List<int>, int, List<int>> excludeDivisible = ExludeDivisible;
            Action<List<int>> reverse = n => n.Reverse();

            numbers = excludeDivisible(numbers, divider);
            reverse(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> ExludeDivisible(List<int> numbers, int divider)
        {
            List<int> excludedNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number % divider != 0)
                {
                    excludedNumbers.Add(number);
                }
            }
            return excludedNumbers;
        }
    }
}
