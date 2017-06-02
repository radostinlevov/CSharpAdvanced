using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbersWithStack
{
    class ReverseNumbersWithStack
    {
        static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            Stack<int> numbersAsStack = new Stack<int>();

            foreach (var number in inputNumbers)
            {
                numbersAsStack.Push(number);
            }

            Console.WriteLine(string.Join(" ", numbersAsStack));
        }
    }
}
