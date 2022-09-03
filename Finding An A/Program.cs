namespace Finding_An_A
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();;
            Console.WriteLine(input.Substring(input.IndexOf("a")));
        }
    }
}