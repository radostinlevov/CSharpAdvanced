using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
            List<char> inputLine = new List<char>(Console.ReadLine());
            Queue<char> parentheses = new Queue<char>();
            bool hasMatch = true;

            while (hasMatch)
            {
                for (int i = 1; i < inputLine.Count; i++)
                {
                    if ((inputLine[i - 1] == '{') && (inputLine[i] == '}'))
                    {
                        parentheses.Enqueue(inputLine[i - 1]);
                        parentheses.Enqueue(inputLine[i]);
                    }
                    else if ((inputLine[i - 1] == '[') && (inputLine[i] == ']'))
                    {
                        parentheses.Enqueue(inputLine[i - 1]);
                        parentheses.Enqueue(inputLine[i]);
                    }
                    else if ((inputLine[i - 1] == '(') && (inputLine[i] == ')'))
                    {
                        parentheses.Enqueue(inputLine[i - 1]);
                        parentheses.Enqueue(inputLine[i]);
                    }
                    else if ((inputLine[i - 1] == ' ') && (inputLine[i] == ' '))
                    {
                        parentheses.Enqueue(inputLine[i - 1]);
                        parentheses.Enqueue(inputLine[i]);
                    }
                }

                for (int i = 0; i < inputLine.Count; i++)
                {
                    if ((inputLine[i] == '{') && (inputLine[inputLine.Count - 1 - i] == '}'))
                    {
                        parentheses.Enqueue(inputLine[i]);
                        parentheses.Enqueue(inputLine[inputLine.Count - 1 - i]);
                    }
                    else if ((inputLine[i] == '[') && (inputLine[inputLine.Count - 1 - i] == ']'))
                    {
                        parentheses.Enqueue(inputLine[i]);
                        parentheses.Enqueue(inputLine[inputLine.Count - 1 - i]);
                    }
                    else if ((inputLine[i] == '(') && (inputLine[inputLine.Count - 1 - i] == ')'))
                    {
                        parentheses.Enqueue(inputLine[i]);
                        parentheses.Enqueue(inputLine[inputLine.Count - 1 - i]);
                    }
                    else if ((inputLine[i] == ' ') && (inputLine[inputLine.Count - 1 - i] == ' '))
                    {
                        parentheses.Enqueue(inputLine[i]);
                        parentheses.Enqueue(inputLine[inputLine.Count - 1 - i]);
                    }
                }

                hasMatch = false;

                while (parentheses.Count > 0)
                {
                    inputLine.Remove(parentheses.Dequeue());
                    hasMatch = true;
                }
            }

            if (inputLine.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
