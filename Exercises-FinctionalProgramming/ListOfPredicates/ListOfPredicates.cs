using System;
using System.Collections.Generic;
using System.Linq;

class ListOfPredicates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

        Predicate<int> predicate = x => x % 1 == 0;

        foreach (var divider in dividers)
        {
            predicate += x => x % divider == 0;
        }

        List<int> numbers = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        numbers = numbers.FindAll(predicate);

        Console.WriteLine(string.Join(" ", numbers));
    }
}