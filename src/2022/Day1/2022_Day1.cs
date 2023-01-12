namespace AdventOfCode;

public class Day1
{
    public int Day1Solution_1()
    {
        int i, j = 0, k = 0;
        string[] input = File.ReadAllLines("../../../2022/Day1/input.txt");
        foreach (string item in input)
        {
            if (item != "")
            {
                i = int.Parse(item);
                j += i;
            }

            if (item == "")
            {
                if (j >= k) k = j;

                j = 0;
            }
        }

        return k;
    }

    public List<int> Day1Solution_2()
    {
        int i, j = 0, k = 0;
        List<int> calories = new();
        string[] input = File.ReadAllLines("../../../2022/Day1/input.txt");
        foreach (string item in input)
        {
            if (item != "")
            {
                i = int.Parse(item);
                j += i;
            }

            if (item == "")
            {
                calories.Add(j);
                j = 0;
            }
        }

        calories.Sort();
        return calories;
    }
}