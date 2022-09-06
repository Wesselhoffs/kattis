namespace Triple_Texting
{
    using System;
    internal class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int wordLenght = input.Length / 3;

            char[] firstWord = input.Substring(0, wordLenght).ToCharArray();
            char[] secondWord = input.Substring(wordLenght, wordLenght).ToCharArray();
            char[] thirdWord = input.Substring(wordLenght * 2, wordLenght).ToCharArray();
            char[] correctWord = new char[wordLenght];

            for (int i = 0; i < wordLenght; i++)
            {
                if (firstWord[i] == secondWord[i] && firstWord[i] == thirdWord[i]) { correctWord[i] = firstWord[i]; }
                else if (firstWord[i] == secondWord[i]) { correctWord[i] = secondWord[i]; }
                else if (firstWord[i] == thirdWord[i]) { correctWord[i] = firstWord[i]; }
                else if (secondWord[i] == thirdWord[i]) { correctWord[i] = secondWord[i]; }
            }
            string result = new string(correctWord);
            Console.WriteLine(result);

        }
    }
}