using System;

public class Program
{
	public static void Main()
	{
        int i = 1, j = 0, k = 0, l = 0;
        string[] input = System.IO.File.ReadAllLines("./input.txt");
        foreach (string item in input)
        {
            i = int.Parse(item);
            k++;
            if (k != 2000)
            {
                try
                {
                    j = int.Parse(input[k]);
                }
                catch(Exception ex) {
                    Console.WriteLine(ex);
                }
            }
            try
            {
                if (i == j)
                {
                    j = int.Parse(input[k + 1]);
                    Console.WriteLine("j is equal lol");
                }
                else if (i < j) {
                l++;
                }
            }
            catch(Exception ex) {
                Console.WriteLine("Ex: " + ex);
            }
        }
        Console.WriteLine(l);
    }
}