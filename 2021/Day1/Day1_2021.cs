namespace AdventOfCode
{
    public class Day1_2021
    {
        public int Day1()
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
                    catch (Exception ex)
                    {
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
                    else if (i < j)
                    {
                        l++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ex: " + ex);
                }
            }

            return (l);
        }
    }
}