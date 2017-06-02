using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main()
        {
            int[] inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numbersAmount = inputLine[0];
            int popAmount = inputLine[1];
            int presentNum = inputLine[2];

            Stack<int> numbersAsStack = new Stack<int>();

            for (int i = 0; i < numbersAmount; i++)
            {
                numbersAsStack.Push(numbers[i]);
            }

            for (int i = 0; i < popAmount; i++)
            {
                numbersAsStack.Pop();
            }

            if (numbersAsStack.Count.Equals(0))
            {
                Console.WriteLine(0);
            }
            else if (numbersAsStack.Contains(presentNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbersAsStack.Min());
            }
        }
    }
}
