using System;
using System.Text;
internal class Program
{
    static void Main(string[] args)
    {
        string originalHey = Console.ReadLine();
        int amountOfE = originalHey.Length - 2;
        StringBuilder sb = new StringBuilder();
        sb.Append("h");
        for (int i = 0; i < amountOfE * 2; i++)
        {
            sb.Append("e");
        }
        sb.Append("y");
        Console.WriteLine(sb);

    }
}