using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSequenceWithQueue
{
    class CalculateSequenceWithQueue
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            List<long> sequence = new List<long>();
            sequence.Add(number);
            Queue<long> calcSeq = new Queue<long>();
            calcSeq.Enqueue(number);

            while (sequence.Count < 50)
            {
                long currentNum = calcSeq.Dequeue();
                long firstNum = currentNum + 1;
                long secondNum = (2 * currentNum) + 1;
                long thirdNum = currentNum + 2;

                sequence.Add(firstNum);
                sequence.Add(secondNum);
                sequence.Add(thirdNum);

                calcSeq.Enqueue(firstNum);
                calcSeq.Enqueue(secondNum);
                calcSeq.Enqueue(thirdNum);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(sequence[i] + " ");
            }
        }
    }
}
