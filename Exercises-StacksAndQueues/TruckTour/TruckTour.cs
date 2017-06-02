using System;
using System.Collections.Generic;

namespace TruckTour
{
    class FuelPump
    {
        public int FuelAmount { get; set; }
        public int DistaceToPump { get; set; }
        public int Index { get; set; }
    }

    class TruckTour
    {
        static void Main()
        {
            int numberPumps = int.Parse(Console.ReadLine());
            Queue<FuelPump> fuelPumps = new Queue<FuelPump>();

            for (int i = 0; i < numberPumps; i++)
            {
                string[] pumpInfo = Console.ReadLine().Split();

                FuelPump fuelPump = new FuelPump();
                fuelPump.FuelAmount = int.Parse(pumpInfo[0]);
                fuelPump.DistaceToPump = int.Parse(pumpInfo[1]);
                fuelPump.Index = i;

                fuelPumps.Enqueue(fuelPump);
            }

            FuelPump starterPump = null;
            bool completeCircle = false;
            int restFuel = 0;

            while (restFuel >= 0)
            {
                FuelPump currentPump = fuelPumps.Dequeue();
                fuelPumps.Enqueue(currentPump);
                restFuel = currentPump.FuelAmount;
                starterPump = currentPump;

                while (restFuel >= currentPump.DistaceToPump)
                {
                    restFuel -= currentPump.DistaceToPump;

                    currentPump = fuelPumps.Dequeue();
                    fuelPumps.Enqueue(currentPump);

                    if (currentPump == starterPump)
                    {
                        completeCircle = true;
                        break;
                    }

                    restFuel += currentPump.FuelAmount;
                }

                if (completeCircle)
                {
                    Console.WriteLine(starterPump.Index);
                    return;
                }
            }
        }
    }
}
