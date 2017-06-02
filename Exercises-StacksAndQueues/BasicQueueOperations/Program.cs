using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main()
        {
            int[] inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbersToAdd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queueOfNumbers = new Queue<int>();

            int addElements = inputLine[0];
            int removeElements = inputLine[1];
            int existingNum = inputLine[2];

            for (int i = 0; i < addElements; i++)
            {
                queueOfNumbers.Enqueue(numbersToAdd[i]);
            }

            for (int i = 0; i < removeElements; i++)
            {
                queueOfNumbers.Dequeue();
            }

            if (queueOfNumbers.Contains(existingNum))
            {
                Console.WriteLine("true");
            }
            else if (queueOfNumbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queueOfNumbers.Min());
            }
        }
    }
}
