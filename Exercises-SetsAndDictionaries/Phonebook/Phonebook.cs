using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split('-');
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (!inputLine[0].ToLower().Equals("search"))
            {
                string name = inputLine[0];
                string phoneNumber = inputLine[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, phoneNumber);
                }
                else
                {
                    phonebook[name] = phoneNumber;
                }

                inputLine = Console.ReadLine().Split('-');
            }

            string contactName = Console.ReadLine();

            while (!contactName.ToLower().Equals("stop"))
            {
                if (phonebook.ContainsKey(contactName))
                {
                    Console.WriteLine($"{contactName} -> {phonebook[contactName]}");
                }
                else
                {
                    Console.WriteLine($"Contact {contactName} does not exist.");
                }

                contactName = Console.ReadLine();
            }
        }
    }
}
