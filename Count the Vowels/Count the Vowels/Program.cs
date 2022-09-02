namespace Count_the_Vowels
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            char[] charInput = input.ToCharArray();
            int vowels = 0;

            foreach (char letter in charInput)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowels++;
                }
            }
            Console.WriteLine(vowels);
        }
    }
}