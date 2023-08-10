namespace AdventOfCode;

using System.Security.Cryptography;
using System.Text;

public class Day4_2015
{
    private readonly string input = "iwrupvqb";
    private int i;

    public int Solution1()
    {
        while (ComputeMD5(input + i).Substring(0, 5) != "00000") i++;
        return i;
    }

    public int Solution2()
    {
        while (ComputeMD5(input + i).Substring(0, 6) != "000000") i++;
        return i;
    }

    public void Solution()
    {
        Console.WriteLine("\nSolution for AoC Day 4 of 2015:");
        Console.WriteLine(Solution1());
        Console.WriteLine(Solution2());
    }

    private static string ComputeMD5(string s)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] hashValue = md5.ComputeHash(Encoding.UTF8.GetBytes(s));
            string hexValue = Convert.ToHexString(hashValue);
            Console.WriteLine(hexValue);
            return hexValue;
        }
    }
}