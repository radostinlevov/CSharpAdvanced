using System;

namespace FormattingNumbers
{
    public class FormattingNumbers
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            double c = double.Parse(numbers[2]);

            Console.WriteLine("|{0}|{1}|{2}|{3}|", a.ToString("X").PadRight(10)
                                         , Convert.ToString(a, 2).PadLeft(10, '0').Substring(0, 10)
                                         , b.ToString("0.00").PadLeft(10), c.ToString("0.000").PadRight(10));
        }
    }
}
