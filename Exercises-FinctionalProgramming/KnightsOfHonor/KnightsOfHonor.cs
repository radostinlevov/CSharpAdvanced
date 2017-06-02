using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    public class KnightsOfHonor
    {
        public static void Main()
        {
            List<string> collectionOfNames = Console.ReadLine()
                                            .Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();
            Action<string> action = n => Console.WriteLine("Sir {0}", n);

            collectionOfNames.ForEach(action);
        }
    }
}
