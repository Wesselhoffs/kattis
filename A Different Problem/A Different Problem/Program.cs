using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        List<long> list1 = new List<long>();
        List<long> list2 = new List<long>();
        string input = null;

        while ((input = Console.ReadLine()) != null)
        {
            long[] numbers = input.Split(" ").Select(long.Parse).ToArray();
            list1.Add(numbers[0]);
            list2.Add(numbers[1]);
        }
        for (int i = 0; i < list1.Count; i++)
        {
            Console.WriteLine(Math.Abs(list1[i] - list2[i]));
        }       
        
    }
}