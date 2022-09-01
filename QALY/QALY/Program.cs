using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double result = 0;
        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(" ");
            double input1 = double.Parse(values[0]);
            double input2 = double.Parse(values[1]);
            result += input1 * input2;
        }
        Console.WriteLine(result);

    }
}