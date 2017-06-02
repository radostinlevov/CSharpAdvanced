using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CustomComparator
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .OrderBy(n => n)
                            .ToList();
        List<int> sortedNumbers = new List<int>();

        Predicate<int> isEven = n => n % 2 == 0;
        Predicate<int> isOdd = n => n % 2 != 0;

        sortedNumbers = numbers.FindAll(isEven);
        sortedNumbers.AddRange(numbers.FindAll(isOdd));

        Console.WriteLine(string.Join(" ", sortedNumbers));
    }
}
