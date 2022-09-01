using System;
internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double result = 0;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            int lastDigit = 1;

            if (input > 10)
            {
                lastDigit = input % 10;
                int inputMinusOne = input / 10;                 
                result += Math.Pow(inputMinusOne, lastDigit);
            }
            else
            {
                result += Math.Pow(input, lastDigit);
            }
                
        }
        Console.WriteLine(result);
    }
}