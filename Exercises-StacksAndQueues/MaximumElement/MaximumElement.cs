using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int[] inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = inputLine[0];

                if (command.Equals(1))
                {
                    int number = inputLine[1];
                    numbers.Push(number);

                    if (number >= maxNumber)
                    {
                        maxNumber = number;
                        maxNumbers.Push(maxNumber);
                    }
                }
                else if (command.Equals(2))
                {
                    if (numbers.Peek() == maxNumbers.Peek())
                    {
                        maxNumbers.Pop();
                    }
                    numbers.Pop();

                    if (maxNumbers.Count > 0)
                    {
                        maxNumber = maxNumbers.Peek();
                    }
                    else
                    {
                        maxNumber = int.MinValue;
                    }

                }
                else if (command.Equals(3))
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
