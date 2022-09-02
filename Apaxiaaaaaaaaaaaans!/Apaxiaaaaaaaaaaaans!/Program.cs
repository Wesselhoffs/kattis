namespace Apaxiaaaaaaaaaaaans_
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();            
            char[] charsInName = inputName.ToCharArray();

            StringBuilder outputName = new StringBuilder();            
            char tempChar = charsInName[0];
            outputName.Append(tempChar);          
            int nameLenght = charsInName.Length;          

            for (int i = 0; i < nameLenght; i++)
            {
                if (tempChar != charsInName[i])
                {
                    outputName.Append(charsInName[i]);
                    tempChar = charsInName[i];
                }
            }

            Console.WriteLine(outputName.ToString());
            
        }
    }
}