using System;
internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] adRevenueMinusCost = new int[n];
        int[] expectedRevenue = new int[n];
        int counter = 0;
        for (int i = 0; i < n; i++)
        {           
            string[] values = Console.ReadLine().Split(" "); 
            adRevenueMinusCost[counter] = int.Parse(values[1]) - int.Parse(values[2]);
            expectedRevenue[counter] = int.Parse(values[0]);

            counter++;
        }
        for (int i = 0; i < n; i++)
        {
            if (adRevenueMinusCost[i] > expectedRevenue[i]) Console.WriteLine("advertise");
            else if (adRevenueMinusCost[i] == expectedRevenue[i]) Console.WriteLine("does not matter");
            else if (adRevenueMinusCost[i] < expectedRevenue[i]) Console.WriteLine("do not advertise");
        }
    }
}
