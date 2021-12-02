using System;

public class Program
{
    public static void Main()
    {
        int f = 0, d = 0, a = 0;
        string[] input = System.IO.File.ReadAllLines("./input.txt");
        foreach (string item in input)
        {
            if (item.StartsWith("forward"))
            {
                // f += value
                f += int.Parse(item.Substring(item.Length - 1));
                d += a * int.Parse(item.Substring(item.Length - 1));
            }
            else if (item.StartsWith("down"))
            {
                // d += value
                a += int.Parse(item.Substring(item.Length - 1));
            }
            else if (item.StartsWith("up"))
            {
                // d -= value
                a -= int.Parse(item.Substring(item.Length - 1));
            }
        }
        Console.WriteLine(f * d);
    }
}