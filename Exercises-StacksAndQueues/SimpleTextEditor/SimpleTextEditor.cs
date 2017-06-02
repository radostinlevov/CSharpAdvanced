using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = "";
            Stack<string> operations = new Stack<string>();
            operations.Push(text);
            for (int i = 0; i < n; i++)
            {
                string[] commandLine = Console.ReadLine()
                                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int command = int.Parse(commandLine[0]);

                if (command.Equals(1))
                {
                    text += commandLine[1];
                    operations.Push(text);
                }
                else if (command.Equals(2))
                {
                    int numberOfLeters = int.Parse(commandLine[1]);
                    text = text.Substring(0, text.Length - numberOfLeters);
                    operations.Push(text);
                }
                else if (command.Equals(3))
                {
                    int index = int.Parse(commandLine[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command.Equals(4))
                {
                    operations.Pop();
                    text = operations.Peek();
                }
            }
        }
    }
}
