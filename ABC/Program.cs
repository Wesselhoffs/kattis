namespace ABC
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            char[] chars = Console.ReadLine().ToCharArray();
            int[] sortedArray = new int[numbers.Length];

            int alocation = Array.IndexOf(chars, 'A');
            int bLocation = Array.IndexOf(chars, 'B');
            int cLocation = Array.IndexOf(chars, 'C');
            Array.Sort(numbers);
            sortedArray[alocation] = numbers[0];
            sortedArray[bLocation] = numbers[1];
            sortedArray[cLocation] = numbers[2];

            Console.WriteLine($"{sortedArray[0]} {sortedArray[1]} {sortedArray[2]}");
        }
    }
}