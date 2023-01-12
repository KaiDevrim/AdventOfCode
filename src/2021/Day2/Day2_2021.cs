namespace AdventOfCode;

public class Day2_2021
{
    public int Day2()
    {
        int f = 0, d = 0, a = 0;
        string[] input = File.ReadAllLines("./input.txt");
        foreach (string item in input)
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

        return f * d;
    }
}