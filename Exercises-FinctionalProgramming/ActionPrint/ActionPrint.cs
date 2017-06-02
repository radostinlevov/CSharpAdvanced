using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionPrint
{
   public class ActionPrint
    {
        public static void Main()
        {
            List<string> collectionNames = Console.ReadLine().Split().ToList();

            Action<string> printName = n => Console.WriteLine(n);

            collectionNames.ForEach(printName);
        }
    }
}
