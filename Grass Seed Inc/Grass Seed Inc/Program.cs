using System;
internal class Program
{
    static void Main(string[] args)
    {
        double costToSeed = double.Parse(Console.ReadLine());
        int numberOfLawns = int.Parse(Console.ReadLine());
        double areaOfCombinedLawns = 0;
        for (int i = 0; i < numberOfLawns; i++)
        {
            string[] lawnMeasurements = Console.ReadLine().Split(" ");
            double widthOfLawn = double.Parse(lawnMeasurements[0]);
            double lenghttOfLawn = double.Parse(lawnMeasurements[1]);
            areaOfCombinedLawns += widthOfLawn * lenghttOfLawn;
        }
        Console.WriteLine(costToSeed * areaOfCombinedLawns);
    }
}