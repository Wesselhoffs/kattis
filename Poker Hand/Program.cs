namespace Poker_Hand
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            string[] input = Console.ReadLine().Split(" ");
            char[] chars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                chars[i] = input[i].First();
            }
            foreach (var item in chars)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item]++;
                }
                else
                {
                    frequency.Add(item, 1);
                }
            }
            var mylist = frequency.OrderByDescending(d => d.Value).ToList();
            Console.WriteLine(mylist.ElementAt(0).Value);
        }
    }
}