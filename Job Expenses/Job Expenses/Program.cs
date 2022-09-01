using System;
internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] values = Console.ReadLine().Split(" ");

        int result = 0;


        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(values[i]);

            if (number < 0) result += Math.Abs(number);
        }
        Console.WriteLine(result);

    }
}