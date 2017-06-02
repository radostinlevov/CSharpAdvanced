using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PredicateParty
{
    static void Main()
    {
        List<string> names = Console.ReadLine()
                             .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                             .ToList();
        List<string> matchOfNames = new List<string>();

        string commandLine = Console.ReadLine();
        while (commandLine != "Party!")
        {
            string[] commandInfo = commandLine
                                   .Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string firstCommand = commandInfo[0];
            string secondCommand = commandInfo[1];

            switch (secondCommand)
            {
                case "StartsWith":
                    string startPart = commandInfo[2];
                    Predicate<string> startMatch = n => n.StartsWith(startPart);

                    if (firstCommand == "Remove")
                    {
                        names.RemoveAll(startMatch);
                    }
                    else if (firstCommand == "Double")
                    {
                        names.AddRange(names.FindAll(startMatch));
                    }
                    break;

                case "EndsWith":
                    string endPart = commandInfo[2];
                    Predicate<string> endMatch = n => n.EndsWith(endPart);

                    if (firstCommand == "Remove")
                    {
                        names.RemoveAll(endMatch);
                    }
                    else if (firstCommand == "Double")
                    {
                        names.AddRange(names.FindAll(endMatch));
                    }
                    break;

                case "Length":
                    long lenght = long.Parse(commandInfo[2]);
                    Predicate<string> lenghtMatch = n => n.Length == lenght;

                    if (firstCommand == "Remove")
                    {
                        names.RemoveAll(lenghtMatch);
                    }
                    else if (firstCommand == "Double")
                    {
                        names.AddRange(names.FindAll(lenghtMatch));
                    }
                    break;
            }

            commandLine = Console.ReadLine();
        }

        if (names.Count == 0)
        {
            Console.Write("Nobody is going to the party!");
        }
        else
        {
            Console.Write(string.Join(", ", names.OrderBy(n => n)));
            Console.Write(" are going to the party!");
            Console.WriteLine();
        }
    }
}
