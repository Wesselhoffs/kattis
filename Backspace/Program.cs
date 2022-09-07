namespace Backspace
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            LessThanBackspace(input);
        }

        static void LessThanBackspace(string input)
        {
            int locationOfLessthan = input.IndexOf('<');
            if (locationOfLessthan != -1)
            {
                string firstPartOfString = input.Substring(0, locationOfLessthan - 1);
                string secondPartOfString = input.Substring(locationOfLessthan + 1);
                string newString = firstPartOfString + secondPartOfString;
                LessThanBackspace(newString);

            }
            else
            {
                Console.WriteLine(input);
            }
        }

    }
}

// This solution is poorly optimized. I get "Memory Limit Exceeded" in kattis test sequence.