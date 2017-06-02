using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFibonacci
{
    class StackFibonacci
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<decimal> fibNums = new Stack<decimal>();
            fibNums.Push(1);
            fibNums.Push(1);

            for (int i = 2; i < n; i++)
            {
                decimal tempNum = fibNums.Pop();
                decimal prevNum = fibNums.Peek();
                fibNums.Push(tempNum);
                fibNums.Push(prevNum + tempNum);

            }
            Console.WriteLine(fibNums.Peek());
        }
    }
}
