using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Dictionary<string, string> correctEmails = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                string[] emailSplit = email.Split('.');
                string domain = emailSplit[1];
                if (domain.ToLower() != "uk" && domain.ToLower() != "us")
                {
                    correctEmails.Add(name, email);
                }

                name = Console.ReadLine();
            }

            foreach (var kvp in correctEmails)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
