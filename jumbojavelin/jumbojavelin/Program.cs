using System;
internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            int lenght = int.Parse(Console.ReadLine());
            res += lenght;
        }
        Console.WriteLine(res - n +1);
    }
}
