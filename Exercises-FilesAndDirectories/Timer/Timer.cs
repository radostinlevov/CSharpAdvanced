using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Timer
    {
        static void Main()
        {
            int firstFileTime = 0;
            int secondFileTime = 0;
            using (StreamReader firstReader = new StreamReader("File1.csv"))
            {
                string line = firstReader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    counter++;
                    line = firstReader.ReadLine();
                }
                firstFileTime = counter;
            }
            using (StreamReader secondReader = new StreamReader("File2.txt.txt"))
            {
                string line = secondReader.ReadLine();
                int counter = 0;

                while (line != null)
                {
                    counter++;
                    line = secondReader.ReadLine();
                }

                secondFileTime = counter;
            }

            if (firstFileTime < secondFileTime)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
