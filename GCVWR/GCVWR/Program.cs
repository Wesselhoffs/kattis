namespace GCVWR
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int grossWeight = int.Parse(input[0]);
            int truckWeight = int.Parse(input[1]);
            int itemsToBring = int.Parse(input[2]);
            int totalWeightOfItems = 0;

            string[] weightOfItems = Console.ReadLine().Split(" ");

            for (int i = 0; i < itemsToBring; i++)
            {
                totalWeightOfItems += int.Parse(weightOfItems[i]);
            }

            Console.WriteLine(((grossWeight - truckWeight) * 0.9) - totalWeightOfItems);
        }
    }
}