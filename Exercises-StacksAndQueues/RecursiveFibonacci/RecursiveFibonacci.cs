using System;
using System.Collections;
using System.Collections.Generic;

namespace RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static decimal[] numbers;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            numbers = new decimal[n + 1];

            decimal fibonacci = GetFibonacci(n);

            Console.WriteLine(fibonacci);
        }

        static decimal GetFibonacci(int n)
        {
            if (numbers[n] == 0)
            {
                if (n <= 2)
                {
                    return 1;
                }
                else
                {
                    numbers[n - 1] = GetFibonacci(n - 1);
                    numbers[n - 2] = GetFibonacci(n - 2);
                    numbers[n] = numbers[n - 1] + numbers[n - 2];
                }
            }

            return numbers[n];
        }
    }
}
