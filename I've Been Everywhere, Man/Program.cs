namespace Everywhere
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases, workTripsTaken;
            List<int> citiesVisited = new List<int>();
            numberOfTestCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                workTripsTaken = int.Parse(Console.ReadLine());
                Dictionary<string, int> cities = new Dictionary<string, int>();
                int counter = 0;
                for (int x = 0; x < workTripsTaken; x++)
                {
                    string tempString = Console.ReadLine();

                    if (cities.ContainsKey(tempString))
                    {
                        // Do nothing!!
                    }
                    else
                    {
                        cities.Add(tempString, 1);
                        counter++;
                    }
                }
                citiesVisited.Add(counter);
            }
            PrintUniqueCities(citiesVisited);
        }
        static void PrintUniqueCities(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}