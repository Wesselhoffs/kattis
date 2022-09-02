namespace FYI
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string telephoneNr = Console.ReadLine();
            char[] arrayOfnumber = telephoneNr.ToCharArray();

            if (arrayOfnumber[0] == '5' && arrayOfnumber[1] == '5' && arrayOfnumber[2] == '5')
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}