using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PredicateForNames
{
    static void Main()
    {
        int nameLenght = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine().Split().ToList();
        Predicate<string> isInLenght = delegate (string s) { return s.Length <= nameLenght; };

        Console.WriteLine(string.Join("\r\n", names.FindAll(isInLenght)));
    }
}