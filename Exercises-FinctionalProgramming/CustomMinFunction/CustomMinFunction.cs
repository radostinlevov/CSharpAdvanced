using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    public class CustomMinFunction
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(n => int.Parse(n)).ToList();

            Func<List<int>, int> func = n => n.Min();

            Console.WriteLine(func(numbers));
        }
    }
}
