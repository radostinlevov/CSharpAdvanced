using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            var citiesByCountry = new Dictionary<string, Dictionary<string, long>>();

            while (inputLine != "report")
            {
                string[] countryInfo = inputLine.Split('|');
                string country = countryInfo[1];
                string city = countryInfo[0];
                int populationByCity = int.Parse(countryInfo[2]);

                if (!citiesByCountry.ContainsKey(country))
                {
                    citiesByCountry.Add(country, new Dictionary<string, long>());
                    citiesByCountry[country].Add(city, populationByCity);
                }
                else
                {
                    citiesByCountry[country][city] = populationByCity;
                }

                inputLine = Console.ReadLine();
            }

            var citiesByCountryOrdered = citiesByCountry.OrderByDescending(p => p.Value.Values.Sum());

            foreach (var outerPair in citiesByCountryOrdered)
            {
                Console.WriteLine($"{outerPair.Key} (total population: {outerPair.Value.Values.Sum()})");

                foreach (var innerPair in outerPair.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"=>{innerPair.Key}: {innerPair.Value}");
                }
            }
        }
    }
}
